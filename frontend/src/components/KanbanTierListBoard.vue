<template>
  <div class="board">
    <div class="row">
      <div class="col-md">
        <task-column
          id="backlogItems"
          title="Backlog"
          class="card-backlog"
          :items="backlogListItems"
        ></task-column>
        <task-column id="trashedItems" title="Trash" class="card-trashed" :items="trashedListItems"></task-column>
      </div>
      <div class="col-md">
        <task-column id="sTodoItems" title="S Tier" class="card-sTier" :items="sTodoListItems"></task-column>
        <task-column id="aTodoItems" title="A Tier" class="card-aTier" :items="aTodoListItems"></task-column>
        <task-column id="bTodoItems" title="B Tier" class="card-bTier" :items="bTodoListItems"></task-column>
        <task-column id="cTodoItems" title="C Tier" class="card-cTier" :items="cTodoListItems"></task-column>
        <task-column id="dTodoItems" title="D Tier" class="card-dTier" :items="dTodoListItems"></task-column>
      </div>
      <div class="col-md">
        <task-column id="doneItems" title="Done" class="card-done" :items="doneListItems"></task-column>
      </div>
    </div>
  </div>
</template>

<script>
import { mapState } from "vuex";
import TaskColumn from "@/components/TaskColumn";
import axios from "axios";

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
    doneListItems: s => s.items.doneItems,
    trashedListItems: s => s.items.trashedItems
  }),
  isStateDirty() {
    return this.$store.state.isStateDirty;
  },
  created: function() {
    if (this.$store.state.isStateDirty) {
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