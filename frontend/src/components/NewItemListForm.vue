<template>
  <div class="add-item-list">
    <!--The v-on binding handles the form's submit event. 
      The .prevent prevents the event from firing it's default action
    The v-model binding to listItemText allows to get the user input.-->
    <form action="#" method="post" v-on:submit.prevent="submitForm">
      <input
        type="text"
        v-model="listItemText"
        placeholder="Add a task to the to-do tier list's backlog"
      />
    </form>
  </div>
</template>

<script>
/**
 * The component's name's NewItemListForm.
 *
 * The data for this component comes from the data() method.
 * The itemListText is bound to the itemListText on the textbox
 * via the v-model.
 * This allow the change in textbox to apply to itemListText.
 *
 * The submitForm() method handles the submitting of the form.
 * A new data's send to the store via a mutation.
 * Here, a mutation called addListItem is invoked and the text
 * property is set to the value of this.listItemText.
 *
 * After the submission, this.listItemText's set to an empty
 * string to allow another submission.
 *
 */
export default {
  name: "NewItemListForm",
  data() {
    return {
      listItemText: ""
    };
  },
  methods: {
    submitForm() {
      if (this.listItemText) {
        this.$store.commit("addListItem", {
          text: this.listItemText,
          status: 0
        });

        this.listItemText = "";
      }
    }
  }
};
</script>

<style>
@import "../assets/styles/newItemListForm.css";
</style>