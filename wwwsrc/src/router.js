import Vue from 'vue'
import Router from 'vue-router'
// @ts-ignore
import Home from './views/Home.vue'
// @ts-ignore
import Primarch from './views/Primarch.vue'
// @ts-ignore
import PrimarchComponent from './components/PrimarchComponent.vue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/primarchs',
      name: 'primarchs',
      component: Primarch
    },
    {
      path: '/primarch',
      name: 'primarch',
      component: PrimarchComponent
    },
    {
      path: '/about',
      name: 'about',
      component: function () {
        // @ts-ignore
        return import(/* webpackChunkName: "about" */ './views/About.vue')
      }
    },
    {
      path: "*",
      redirect: '/'
    }

  ]
})
