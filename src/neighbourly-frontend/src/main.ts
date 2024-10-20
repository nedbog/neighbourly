import './assets/main.css'

import { createApp } from 'vue'
import { createPinia } from 'pinia'
import PrimeVue from 'primevue/config';

import App from './App.vue'
import router from './router'
import axios from 'axios'

const app = createApp(App)

app.use(createPinia())
app.use(router)
app.use(PrimeVue, { /* options */ });

axios.interceptors.request.use(
    (config) => {
      const token = localStorage.getItem('neighbourly-jwt-token');
      if (token) {
        config.headers['Authorization'] = 'Bearer ' + token;
      }
      return config;
    },
    (error) => {
      if (error.response.status === 401) {
        router.push('/login');
      }

      return Promise.reject(error);
    }
  );
  
app.mount('#app')
