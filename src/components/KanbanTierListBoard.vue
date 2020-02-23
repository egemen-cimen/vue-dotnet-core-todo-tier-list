<template>
  <div class="board">
    <div class="row">
      <div class="col-md">
        <task-column id="backlog" title="Backlog" :items="backlogListItems"></task-column>
      </div>
      <div class="col-md">
        <task-column id="todo" title="To-do" :items="todoListItems"></task-column>
      </div>
      <div class="col-md">
        <task-column id="done" title="Done" :items="doneListItems"></task-column>
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
    "task-column": TaskColumn
  },
  computed: mapState({
    backlogListItems: s => s.items.backlogItems,
    todoListItems: s => s.items.todoItems,
    doneListItems: s => s.items.doneItems
  })
};
</script>