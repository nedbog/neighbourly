<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import Authenticate from './components/authentication/Authenticate.vue'
</script>

<template>
  <header>
    <div class="wrapper">
      <Authenticate />
    </div>
  </header>
  <RouterView />
</template>

<style scoped>
</style>
