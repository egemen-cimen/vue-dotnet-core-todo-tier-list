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
import axios from "axios";

export default {
  name: "Backlog",
  components: {
    "new-item-list": NewItemListForm
  },
  computed: mapState({
    items: s => s.items.backlogItems,
    isStateDirty() {
      return this.$store.state.isStateDirty;
    }
  }),
  created: function() {
    if (this.isStateDirty) {
      this.$store.commit("setNotDirty");
      axios
        .get("https://localhost:5001/TodoTierList", {
          crossdomain: true
        })
        .then(response => {
          this.data = response.data;
          this.data.forEach(item => {
            this.$store.commit("addListItem", {
              text: item.text,
              status: item.status,
              id: item.id
            });
          });
        });
    }
  }
};
</script>
