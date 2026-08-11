# Digital Receipt – Receipt Items – Mobile View Shows Validation Error

## Description

When opening the **Create Receipt** page in the mobile view, the unit price validation message was displayed immediately, before the user interacted with the form or attempted to submit it.

The validation message should only appear after the user submits invalid data.

---

## Root Cause

The mobile receipt item contained a hardcoded validation element:

```html
<span class="text-danger">
    מחיר יחידה חייבת להיות גדולה מ-0
</span>
```

Unlike the desktop validation, this element was always visible because it did not use the shared `validation-error` class that is hidden by default and controlled by JavaScript.

---

## Solution

Replaced the hardcoded validation element with the shared validation mechanism used throughout the page.

The error is now:

- Hidden when the page loads.
- Displayed only after validation fails.
- Hidden again once the user enters valid values.

This keeps the mobile and desktop validation behavior consistent.

---

## Before

![Before](Digital%20receipt%20-%20Receipt%20items%20-%20mobile%20view%20shows%20error.png)

---

## After

![After](Digital%20receipt%20-%20Receipt%20items%20-%20mobile%20view%20shows%20error%20-%20Done.png)
