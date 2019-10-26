import Vue from 'vue'
//@ts-ignore
import App from './App.vue'
import router from './router'
import store from './store'
import { inherits } from 'util'






// Vue.config.productionTip = false
async function init() {
  new Vue({
    router,
    store,
    render: h => h(App)
  }).$mount('#app')
}
init()

