<script setup lang="ts">
import axios from 'axios';
import { ref } from 'vue';
import { useRouter } from 'vue-router';
import InputText from 'primevue/inputtext';
import Password from 'primevue/password';
import Checkbox from 'primevue/checkbox';
import Button from 'primevue/button';

const email = ref<string>('');
const password = ref<string>('');
const rememberMe = ref<boolean>(false);
const router = useRouter();

const login = async () => {
  try {
    const response = await axios.post('https://localhost:7092/authentication/login', {
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
      <div class="flex flex-col gap-2">
        <label for="username">Email</label>
        <InputText id="username" v-model="email" aria-describedby="username-help" type="email" />
      </div>
      <div class="flex flex-col gap-2">
        <label for="password">Password</label>
        <Password id="password" v-model="password" :feedback="false" toggleMask />
      </div>
      <div class="flex items-center">
        <label for="remember-me" class="ml-2"> Remember me </label>
        <Checkbox v-model="rememberMe" inputId="remember-me" name="rememberMe" value="rememberMe" />
      </div>
      <Button type="submit" label="Login" icon="pi pi-search" />
    </form>
  </main>
</template>

<style scoped></style>
