import { baseUrl } from '@/config/global'

export default class CampaignService{
    constructor(http){
        this._http = http
    }

    getByDate(date){
        return this._http
            .get(`${baseUrl}/campaigns/${date}`)
    }
}