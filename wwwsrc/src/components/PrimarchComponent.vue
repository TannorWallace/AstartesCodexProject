<template>
  <div class="container-fluid border border-dark">
    <h2>The Primarchs</h2>
    <h1>is this even working!?</h1>
    <div class="row">
      <div class="Primarchs" v-for="Primarch in Primarch">
        <div class="card-body">
          <img src="Primarch.img" class="card-img-top" alt="...">
          <h5 class="card-title">{{primarch.name}}</h5>
          <p class="card-text">{{primarch.orgin}} </p>
          <!-- <a href="#" class="btn btn-primary">Go somewhere</a> -->
        </div>
      </div>

    </div>


  </div>
</template>


<script>
  import router from '../router'
  import PrimarchComponent from '@/components/PrimarchComponent.vue'
  export default {
    name: 'PrimarchComponent',
    data() {
      return {}
    },
    mounted() {
      this.$store.dispatch('getPrimarch')
    },
    // add a mounted for the store here?
    computed: {
      Primarch() {
        return this.$store.state.Primarch
      }
    },
    methods: {
      Home() {
        router.push({ name: 'Home' })
      },
      selectedPrimarch(Primarch) {
        this.$router.push({ name: "selectedPrimarch", params: { PrimarchId: Primarch.id } })
      }
    },
    components: {}
  }
</script>


<style scoped>

</style>