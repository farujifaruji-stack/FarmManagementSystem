# Digital Receipt – Receipt Items – Receipt Items Cleared When Receipt Number Already Exists

## Description

When creating a receipt with an existing receipt number, the server correctly rejected the submission and returned the page with a validation error.

However, only the first receipt item was displayed after the page was reloaded. Any additional receipt items that had been added by the user disappeared, forcing them to re-enter the data.

---

## Root Cause

The receipt items were generated dynamically on the client side using JavaScript.

When the page was returned after the validation error (`return Page();`), the `Receipt.Items` collection still contained all submitted items, but the Razor view only rendered `Receipt.Items[0]`.

As a result, only the first receipt item was recreated after the page refresh.

---

## Solution

Updated the Razor view to render the receipt items using a `for` loop instead of a single hardcoded row.

Each receipt item is now recreated from the `Receipt.Items` collection, ensuring that all user-entered data is preserved when the page is returned due to a validation error.

---

## Before

The page returned only the first receipt item after a duplicate receipt number was detected.

## Before

**Reproduction**

[Watch reproduction](./Digital%20receipt%20-%20Receipt%20items%20-%20If%20receipt%20number%20exists,%20receipt%20Items%20are%20cleared%20-%20reproduce.mp4)

---

## After

![After](./Digital%20receipt%20-%20Receipt%20items%20-%20If%20receipt%20number%20exists,%20receipt%20Items%20are%20cleared%20-%20Done.png)
