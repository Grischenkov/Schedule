function showHideDiv(showId)
{
	document.getElementById('month-view').style.display = 'none';
	document.getElementById('week-view').style.display = 'none';
	document.getElementById('day-view').style.display = 'none';
	document.getElementById(showId).style.display = 'block';
}

function showDiv(id)
{
	document.getElementById(id).style.display = 'block';
}