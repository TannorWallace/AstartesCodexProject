<template>
  <div class="container-fluid">
    <h2>The Primarchs</h2>
    <div class="row Primarchs" v-for="Primarch in Primarch">
      <div class="card" style="width: 18rem;">
        <img src="..." class="card-img-top" alt="...">
        <div class="card-body">
          <h5 class="card-title">{{Primarch.name}}</h5>
          <p class="card-text">
          </p>
          <a href="#" class="btn btn-primary">Go somewhere</a>
        </div>
      </div>

    </div>


  </div>
</template>


<script>
  export default {
    name: 'PrimarchComponent',
    data() {
      return {}
    },
    // add a mounted for the store here?
    computed: {},
    methods: {},
    components: {}
  }
</script>


<style scoped>

</style>