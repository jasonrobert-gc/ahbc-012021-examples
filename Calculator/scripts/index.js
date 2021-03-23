$('document').ready(() => {
    let left, opt;

    $('button').click((e) => {
        switch (e.target.name) {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                const output = $('#number');
                output.val(output.val() + e.target.name);
                break;
            case 'clear':
                $('#number').val('');
                break;
            case '+':
            case '-':
            case '*':
            case '%':
                left = parseInt($('#number').val());
                opt = e.target.name;
                $('#number').val('');
                break;
            case '=':
                calculate(parseInt($('#number').val()));
                break;
            default:
                break;
        }
    });

    function calculate(right) {
        switch (opt) {
            case '+':
                $('#number').val(left + right);
                left = opt = undefined;
                break;
            case '-':
                $('#number').val(left - right);
                left = opt = undefined;                
                break;
            case '%':
                $('#number').val(left % right);
                left = opt = undefined;     
                break;
            case '*':
                $('#number').val(left * right);
                left = opt = undefined;     
                break;
            default:
                break;
        }
    }
});