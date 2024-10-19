import { createRouter, createWebHistory } from 'vue-router'
import Authenticate from '@/components/authentication/Authenticate.vue'
import Login from '@/components/authentication/Login.vue'
import Register from '@/components/authentication/Register.vue'
import App from '@/App.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/login',
      name: 'login',
      component: Login
    },
    {
      path: '/register',
      name: 'register',
      component: Register
    }
  ]
})

export default router
