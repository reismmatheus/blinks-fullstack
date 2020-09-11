<template>
    <div>
      <b-row>
        <b-col offset="1" cols="10">
          <h4 class="mb-5 text-center">Campaings</h4>

          <label for="example-datepicker">Choose a date for search</label>
          <b-form-datepicker id="example-datepicker" v-model="search" class="mb-2"></b-form-datepicker>
          
          <b-table 
            class="mt-4"
            striped hover 
            :items="items" 
            :fields="fields"
            show-empty
            empty-text="Empty">
          </b-table>
          <b-pagination
            v-model="currentPage"
            :total-rows="rows"
            :per-page="perPage"
            align="center"
          ></b-pagination>
        </b-col>
      </b-row>
    </div>
</template>

<script>
import CampaignService from '@/services/CampaignService'

export default {
    data() {
      return {
        search: '',
        currentPage: 1,
        perPage: 10,
        fields: [
          { key: 'client_id', label: 'Client ID', sortable: true },
          { key: 'date', label: 'Date', sortable: true },
          { key: 'media', label: 'Media', sortable: true },
          { key: 'client_name', label: 'Client Name', sortable: true },
          { key: 'campaign_id', label: 'Campaign ID', sortable: true },
          { key: 'campaign_name', label: 'Campaign Name', sortable: true },
          { key: 'clicks', label: 'Clicks', sortable: true },
          { key: 'impressions', label: 'Impressions', sortable: true },
          { key: 'investment', label: 'Investment', sortable: true },
        ],
        items: []
      }
    },
    methods: {
      makeToast(variant, title, body) {
        this.$bvToast.toast(body, {
          title: `${title}`,
          variant: variant,
          solid: true
        })
      }
    },
    mounted() {
      this.service = new CampaignService(this.$http);
    },
    computed: {
      rows() {
        return this.items.length
      }
    },
    watch: {
      search(value) {
        this.items = [];
      
        const date = value.split('-');

        this.service.getByDate(`${date[2]}${date[1]}${date[0]}`)
          .then(response => {
            if(response.data.total == 0){
              this.makeToast('warning', 'Attention', 'Without registered campaign!')
            }
            else{
              this.items = response.data.data
            }
          })
          .catch(error => {
            console.log(error)
            this.makeToast('danger', 'Error', 'Unexpected Error')
          })
      }
  }
}
</script>

<style>

</style>