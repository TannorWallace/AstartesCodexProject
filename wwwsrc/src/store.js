import Vue from 'vue'
import Vuex from 'vuex'
import Axios from 'axios'
import router from './router'


Vue.use(Vuex)

let baseUrl = location.host.includes('localhost') ? '//localhost:5000/' : '/'

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 3000
})

export default new Vuex.Store({
  state: {
    Primarchs: [],
    selectedPrimarch: {},




  },
  mutations: {
    setPrimarch(state, data) {
      state.Primarchs = data
    },
    setSelectedPrimarch(state, data) {
      state.selectedPrimarch = data
    }


  },
  actions: {
    async getPrimarch({ dispatch, commit }) {
      try {
        let res = await api.get('Primarch')
        commit('setPrimarch', res.data)
      }
      catch (error) { console.log(error) }
    },
    async getPrimarchById({ dispatch, commit }, payload) {
      try {
        let res = await api.get('Primarch/' + payload)
        commit('setSelectedPrimarch', res.data)
      }
      catch (error) { console.log(error) }
    }

  }
})
