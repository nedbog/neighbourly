<script setup lang="ts">
import axios from 'axios';
import { ref } from 'vue';
import { useRouter } from 'vue-router';

const email = ref<string>('');
const password = ref<string>('');
const rememberMe = ref<boolean>(false);
const router = useRouter();

const login = async () => {
  try {
    const response = await axios.post('https://localhost:7092/authentication/login/', {
      email: email.value,
      password: password.value,
      rememberMe: rememberMe.value
    });
    const token = response.data.token;
    localStorage.setItem('neighbourly-jwt-token', token);
    router.push('/');
  } catch (error) {
    console.error(error);
  }
};

</script>

<template>
  <main>
    <form @submit.prevent="login">
      <div>
        <label>Username</label>
        <input type="email" v-model="email" />
      </div>
      <div>
        <label>Password</label>
        <input type="password" v-model="password" />
      </div>
      <div>
        <label>Remember Me</label>
        <input type="checkbox" v-model="rememberMe" />
      </div>
      <button type="submit">Login</button>
    </form>
  </main>
</template>

<style scoped>
</style>
