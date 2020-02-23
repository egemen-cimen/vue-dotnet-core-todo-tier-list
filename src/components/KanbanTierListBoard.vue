<template>
  <div class="board">
    <div class="row">
      <div class="col-md">
        <task-column id="backlog" title="Backlog" :items="todoListItems"></task-column>
      </div>
    </div>
  </div>
</template>

<script>
import { mapState } from "vuex";
import TaskColumn from "@/components/TaskColumn";

export default {
  name: "KanbanTierListBoard",
  components: {
    "task-column": TaskColumn,
  },
  computed: mapState({
    todoListItems: s => s.items.todoItems
  })
};
</script>