Hello,
This is John Yangco and this my leaderboard mvp exercise code.
Assumptions:

only skeletal code is checked-in but testable
all error handling we're not considered anymore
console-based implementation only
admin sets up the leaderboards(hard coded, only 2 leaderboards)

How to test the code:
- user selects if [1]referee or a [2]subscriber
- select 0 to exit
- select 1 or 2 from the keyboard
- if user selects 1:
	- enter referee password ("refAdmin" - hard coded)
	- if invalid, show message for invalid password
	- if valid, select leaderboard to score.
	- select 1 or 2 from the keyboard
	- the user will then see the available H2H in round robin format
	- the user then selects the H2H to score (input the number of the H2H)
	- the scoring is hard coded (first player = 5, second player = 4)
	- leaderboards are displayed
	- user can continue or press 0 to exit
- if user selects 2:
	- enter subscriber password ("subAdmin" - hard coded)
	- if invalid, user can see the public leaderboards only.
	- if valid, user can see all leaderboards. user is considered admin if password passes.
	
How easy is it for another developer to continue where you left off?
- Code is extensible, no hard coupling.