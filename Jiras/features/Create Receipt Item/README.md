# Create Receipt Item

## Description

Develop functionality that allows farm administrators to add individual items to a digital receipt. Each receipt item represents a purchased product or service and captures the pricing, quantity, and product information at the time of the transaction. Product details are stored as a snapshot to preserve historical accuracy, ensuring receipt information remains unchanged even if the original product information is modified later.

---

## Fields

- Receipt
- Product
- Unit Price
- Quantity
- Total
- Product Name Snapshot
- Description Snapshot
- Was On Sale
- Product Price Rule

---

## Business Rules

- Every receipt item must be associated with an existing digital receipt.
- Every receipt item must reference a valid product.
- Total is automatically calculated as **Unit Price × Quantity**.
- Product Name Snapshot stores the product name at the time the receipt is created.
- Description Snapshot stores the product description at the time the receipt is created.
- Receipt item information must remain unchanged even if the product information is updated in the future.
- Sale information and pricing rules are recorded when applicable.

---

## Acceptance Criteria

- Administrators can add one or more items to a digital receipt.
- Product information is retrieved from the selected product.
- Unit price and quantity are validated before saving.
- Total is calculated automatically.
- Receipt item information is successfully saved.
- Snapshot information is stored with the receipt item.
- Validation messages are displayed when required information is missing or invalid.

---

## Jira

_Add Jira screenshot here._
