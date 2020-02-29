<template>
  <div class="card task-column-item">
    <div class="card-block">
      <h5 class="card-title">
        <span class="text-muted">#{{item.id}}</span>
        {{item.text}}
      </h5>
    </div>
  </div>
</template>
<script>
export default {
  name: "TaskColumnItem",
  props: ["item"]
};
</script>

<style>
@import "../assets/styles/taskColumnItem.css";
</style>