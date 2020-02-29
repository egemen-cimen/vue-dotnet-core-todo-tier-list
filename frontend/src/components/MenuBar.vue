 <template>
  <div class="menubar">
    <div class="btn-group" role="group" aria-label="Menu bar">
      <!--v-bind button classes to router links-->
      <router-link to="/board" :class="buttonClass('/board')">Kanban Tier List Board</router-link>
      <router-link to="/backlog" :class="buttonClass('/backlog')">Backlog</router-link>
    </div>
  </div>
</template>
  <script>
export default {
  name: "MenuBar",
  methods: {
    /**
     * Match buttons' router path with the current path and highlight the current path's button
     */
    buttonClass(path) {
      return {
        btn: true,
        "btn-primary": this.$route.path === path,
        "btn-secondary": this.$route.path !== path
      };
    }
  }
};
</script>