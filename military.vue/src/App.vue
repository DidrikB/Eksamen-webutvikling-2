<template>
  <the-navigation></the-navigation>
  <router-view/>
</template>

<script>
import TheNavigation from "./components/shared/TheNavigation.vue"
export default {
  components: {
    TheNavigation
  }
}
</script>

<style>

</style>
