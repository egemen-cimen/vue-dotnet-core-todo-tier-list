<template>
  <div class="board">
    <div class="row">
      <div class="col-md">
        <task-column id="backlogItems" title="Backlog" :items="backlogListItems"></task-column>
      </div>
      <div class="col-md">
        <task-column id="sTodoItems" title="S Tier" :items="sTodoListItems"></task-column>
        <task-column id="aTodoItems" title="A Tier" :items="aTodoListItems"></task-column>
        <task-column id="bTodoItems" title="B Tier" :items="bTodoListItems"></task-column>
        <task-column id="cTodoItems" title="C Tier" :items="cTodoListItems"></task-column>
        <task-column id="dTodoItems" title="D Tier" :items="dTodoListItems"></task-column>
      </div>
      <div class="col-md">
        <task-column id="doneItems" title="Done" :items="doneListItems"></task-column>
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
    sTodoListItems: s => s.items.sTodoItems,
    aTodoListItems: s => s.items.aTodoItems,
    bTodoListItems: s => s.items.bTodoItems,
    cTodoListItems: s => s.items.cTodoItems,
    dTodoListItems: s => s.items.dTodoItems,
    doneListItems: s => s.items.doneItems
  })
};
</script>