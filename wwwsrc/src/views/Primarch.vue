<template>
  <div class="Primarch">
    <h1>Testing 1...2...3</h1>
    <PrimarchComponent></PrimarchComponent>


  </div>
</template>


<script>
  import router from '../router'
  import PrimarchComponent from '@/components/PrimarchComponent.vue'

  export default {
    name: 'Primarch',
    data() {
      return {}
    },
    computed: {},
    methods: {},
    mounted() {
      this.$store.dispatch('getPrimarch', this.$route.params.id)
    },
    components: {
      PrimarchComponent
    }
  }
</script>


<style scoped>

</style>