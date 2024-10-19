<script setup lang="ts">
import { RouterView } from 'vue-router'
import Authenticate from './components/authentication/Authenticate.vue'
import NavBar from './components/navigation/NavBar.vue';

const isAuthenticated = localStorage.getItem('neighbourly-jwt-token') ? true : false;
</script>

<template>
  <header>
    <div v-if="isAuthenticated">
      <NavBar />
    </div>
    <div v-else>
      <Authenticate />
    </div>
  </header>
  <RouterView />
</template>

<style scoped>
</style>
