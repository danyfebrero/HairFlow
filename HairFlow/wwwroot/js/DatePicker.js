$(function () {

    function WireUpDatePicker()
    {
        const addMonths = 12;
        var currentDate = new Date();

         $('.datepicker').datepicker(
                {
                    dateFormat: 'yy-mm-dd',
                    minDate: currentDate,
                    maxDate: AddSubtractMonths(currentDate, addMonths)
                }
         );
    }

    WireUpDatePicker();

});
