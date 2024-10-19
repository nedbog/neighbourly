<script setup lang="ts">
</script>

<template>
  <div class="greetings">
    <h1 class="green">Neighbourly</h1>
    <nav>
      <RouterLink to="/login">Log in</RouterLink>
      <RouterLink to="/register">Register</RouterLink>
    </nav>
  </div>
</template>

<style scoped>
h1 {
  font-weight: 500;
  font-size: 2.6rem;
  position: relative;
  top: -10px;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
  font-weight: bold;
}

.greetings {
  padding-top: 2rem;
  font-weight: normal;
  width: 100vw;
  display: flex;
  flex-direction: column;
  align-items: center;
}

a,
.green {
  text-decoration: none;
  color: hsla(160, 100%, 37%, 1);
  transition: 0.4s;
  padding: 3px;
}

@media (hover: hover) {
  a:hover {
    background-color: hsla(160, 100%, 37%, 0.2);
  }
}
</style>
