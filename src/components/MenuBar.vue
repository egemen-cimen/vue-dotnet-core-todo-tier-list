 <template>
  <div class="menubar">
    <div class="btn-group" role="group" aria-label="Menu bar">
      <router-link to="/board">Kanban Tier List Board</router-link>
      <router-link to="/backlog">Backlog</router-link>
    </div>
  </div>
</template>
  <script>
export default {
  name: "MenuBar"
};
</script>