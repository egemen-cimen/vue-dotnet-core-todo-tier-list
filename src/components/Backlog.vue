<template>
  <div class="backlog-view">
    <new-item-list></new-item-list>
    <div class="card" v-for="item in items" :key="item.id">
      <div class="card-block">
        <h5 class="card-title">
          <span class="text-muted">#{{item.id}}</span>
          {{item.text}}
        </h5>
      </div>
    </div>
    <p>Total items in the Backlog: {{items.length}}</p>
  </div>
</template>

<script>
/**
 * Connect the store to retrieve data (using mapState method)
 */

import { mapState } from "vuex";
import NewItemListForm from "./NewItemListForm";

export default {
  name: "Backlog",
  components: {
    "new-item-list": NewItemListForm
  },
  computed: mapState({
    items: s => s.items.todoItems
  })
};
</script>
