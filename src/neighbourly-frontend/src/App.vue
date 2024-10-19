<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import Authenticate from './components/authentication/Authenticate.vue'

const isAuthenticated = localStorage.getItem('neighbourly-jwt-token') ? true : false;
</script>

<template>
  <header>
    <div v-if="isAuthenticated">
      <h1>authenticated</h1>
    </div>
    <div v-else>
      <Authenticate />
    </div>
  </header>
  <RouterView />
</template>

<style scoped>
</style>
