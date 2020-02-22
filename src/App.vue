<template>
  <div id="app">
    <div class="page-header">
      <h1>Todo Tier List</h1>
      <p class="lead">It's a todo tier list which works like a kanban board.</p>
    </div>
    <router-view />
    <p>Egemen Çimen - 2020</p>
  </div>
</template>
<script>
export default {
  name: "app"
};
</script>
<style>

@import './app.css';

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #1e1e1e;
}
</style>
