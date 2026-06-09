<p align="center">
  <b>jokenpo</b>
</p>

<p align="center">
  a small rock · paper · scissors game for the console.<br>
  built live during a coding interview.
</p>

---

**// architecture**

a single console project split by responsibility: an enum for the moves, a model for a match, a service holding the game rules, and a thin ui layer for the console loop. the ui talks to the service, the service owns the logic.

- game rules isolated in a service, fully decoupled from input/output
- the console layer only reads input and prints results
- moves modeled as an enum so the comparisons stay readable

**// stack**

`.NET 10` · `C#` · `Console`

**// under the hood**

- **rules** the player move is compared against a random computer move to decide win, loss or draw
- **flow** a read-eval-print loop keeps the game running until the player quits
- **input** invalid options are caught and the loop simply asks again