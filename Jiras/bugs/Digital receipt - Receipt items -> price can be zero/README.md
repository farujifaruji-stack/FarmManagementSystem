# BUG – Receipt Submission Allows Zero Price

## Summary

Submitting a digital receipt with a receipt item that has a price of **0** does not display a validation error. The receipt is submitted successfully instead of preventing the operation.

---

## Environment

- Environment: Development
- Module: Financial Management & Digital Receipts
- Feature: Create Digital Receipt

---

## Reproduction Steps

1. Log in using a valid account.
2. Navigate to **Create Digital Receipt**.
3. Fill in the receipt information.
   - Receipt Number: Any valid value
   - Supplier: Any valid value
4. Add receipt items:
   - **Item 1**
     - Quantity: **1**
     - Unit Price: **0**
   - **Item 2**
     - Quantity: **4**
     - Unit Price: **60**
5. Click **Submit**.

---

## Expected Result

The system should prevent the receipt from being submitted and display a validation message indicating that the unit price must be greater than zero.

---

## Actual Result

The receipt is submitted successfully without displaying any validation message, even though one of the receipt items has a unit price of zero.

---

## Impact

Users can create receipts containing invalid pricing information, resulting in inaccurate financial records and potentially affecting reporting and auditing.

---

## Priority

High

---

## Severity

Major

---

## Related Feature

Create Digital Receipt

---

## Jira

_Add Jira screenshot here._

---

## Screenshots

### Reproduction Steps

![Reproduction Steps](repro-steps.png)

### Expected vs Actual Result

![Expected vs Actual Result](expected-actual-result.png)
