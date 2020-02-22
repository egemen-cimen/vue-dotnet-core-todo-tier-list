<template>
  <div class="backlog-view">
    <new-item-list></new-item-list>
    <p>Backlog</p>
  </div>
</template>

<script>
import NewItemListForm from "./NewItemListForm";

export default {
  name: "Backlog",
  components: {
    "new-item-list": NewItemListForm
  }
};
</script>