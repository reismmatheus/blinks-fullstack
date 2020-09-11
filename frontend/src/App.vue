<template>
  <div id="app">
    <Campaign/>
  </div>
</template>

<script>
import Campaign from './components/Campaign.vue'

export default {
  name: 'App',
  components: {
    Campaign
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
