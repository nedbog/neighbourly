<script setup lang="ts">
import Menubar from 'primevue/menubar';
import { ref } from "vue";

const items = ref([
  {
    label: 'Home',
    icon: 'pi pi-home'
  },
  {
    label: 'Login',
    icon: 'pi pi-star',
    route: '/login'
  },
  {
    label: 'Projects',
    icon: 'pi pi-search',
    items: [
      {
        label: 'Components',
        icon: 'pi pi-bolt'
      },
      {
        label: 'Blocks',
        icon: 'pi pi-server'
      },
      {
        label: 'UI Kit',
        icon: 'pi pi-pencil'
      },
      {
        label: 'Templates',
        icon: 'pi pi-palette',
        items: [
          {
            label: 'Apollo',
            icon: 'pi pi-palette'
          },
          {
            label: 'Ultima',
            icon: 'pi pi-palette'
          }
        ]
      }
    ]
  },
  {
    label: 'Contact',
    icon: 'pi pi-envelope'
  }
]);

</script>

<template>
  <div class="card">
    <Menubar :model="items" />
  </div>
</template>

<style scoped>
h1 {
  color: white;
  background-color: red;
}

nav {
  width: 100vw;
  height: 0.05 * 100vh;
}

.card {
  background: var(--card-bg);
  border: var(--card-border);
  padding: 2rem;
  border-radius: 10px;
  margin-bottom: 1rem;
}
</style>
