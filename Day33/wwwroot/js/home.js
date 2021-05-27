
$('#search').click(o => {
    const species = $('#species').val();

    $.ajax({
        type: 'GET',
        url: `data/${species}.json`,
        success: function (response) {
            $('#name').text(response.name);
            $('#habitat').text(response.habitat);
            $('#diet').text(response.diet);
            console.log(response);
        },
        error: function (response) {
            console.error(response);
        }
    });
});