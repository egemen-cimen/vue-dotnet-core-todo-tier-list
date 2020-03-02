<template>
  <div class="card">
    <h3 class="card-header">{{title}}</h3>
    <div class="card-body">
      <draggable v-model="draggables" :options="{group: 'default'}">
        <div v-for="item in items" :key="item.id">
          <item :item="item"></item>
        </div>
      </draggable>
    </div>
    <div class="card-footer text-muted">{{itemCount}}</div>
  </div>
</template>

<script>
import TaskColumnItem from "@/components/TaskColumnItem";
import Draggable from "vuedraggable";
import axios from "axios";

export default {
  name: "TaskColumn",
  props: ["items", "title", "id"],
  components: {
    item: TaskColumnItem,
    draggable: Draggable
  },
  computed: {
    itemCount() {
      if (!this.items) return "";
      if (this.items.length === 1) return "1 item";
      return `${this.items.length} items`;
    },
    draggables: {
      get() {
        return this.items;
      },
      set(items) {
        axios.post("https://localhost:5001/TodoTierList", items);
        this.$store.commit("updateListItems", {
          items,
          id: this.id
        });
      }
    }
  }
};
</script>>

<style>
@import "../assets/styles/taskColumn.css";
</style>