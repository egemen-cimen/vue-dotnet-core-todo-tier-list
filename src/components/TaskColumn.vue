<template>
  <div class="card">
    <h3 class="card-header">{{title}}</h3>
    <div class="card-body">
      <div v-for="item in items" :key="item.id">
        <item :item="item"></item>
      </div>
    </div>
    <div class="card-footer text-muted">{{itemCount}}</div>
  </div>
</template>

<script>
import TaskColumnItem from "@/components/TaskColumnItem";
export default {
  name: "TaskColumn",
  props: ["items", "title", "id"],
  components: {
    item: TaskColumnItem
  },
  computed: {
    itemCount() {
      if (!this.items) return "";
      if (this.items.length === 1) return "1 item";
      return `${this.items.length} items`;
    }
  }
};
</script>>
