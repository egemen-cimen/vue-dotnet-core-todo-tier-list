<template>
  <div id="app">
    <div class="page-header">
      <h1>To-do Tier List</h1>
      <p class="lead">A to-do list which works like a tier list within a kanban board.</p>
    </div>
    <menu-bar></menu-bar>
    <router-view />
    <p>Egemen Çimen - 2020</p>
  </div>
</template>
<script>
import MenuBar from "@/components/MenuBar";

export default {
  name: "app",
  components: {
    "menu-bar": MenuBar
  }
};
</script>
<style>
@import "./app.css";

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #1e1e1e;
}
</style>
