document.addEventListener('DOMContentLoaded', function () {
    var form = document.getElementById('fizzBuzzForm');
    var input = document.getElementById('values');
    var errorMessage = document.getElementById('errorMessage');
    var errorText = document.getElementById('errorText');
    var clearBtn = document.getElementById('clearBtn');
    var resultsList = document.getElementById('resultsList');

    form.addEventListener('submit', function (event) {
        var regex = /^[a-zA-Z0-9,]*$/;

        if (input != null && input.value == "") {
            errorText.textContent = "Input cannot be empty";
            event.preventDefault();
            return false;
        }

        if (!regex.test(input.value)) {
            var invalidCharecters = 'Invalid input: Only alphanumeric characters and commas are allowed.';

            errorText.textContent = invalidCharecters; 

            // Clear the results list
            while (resultsList != null && resultsList.firstChild) {
                resultsList.removeChild(resultsList.firstChild);
            }

            //if (errorMessage != null) {
            //    errorMessage.textContent = invalidCharecters;
            //    errorMessage.style.display = 'block';
            //}

            event.preventDefault();
        } else {
            errorText.textContent = '';
            if (errorMessage != null) {
                errorMessage.style.display = 'none';
            }
        }
    });

    clearBtn.addEventListener('click', function () {
        input.value = '';

        if (errorMessage != null) {
            errorMessage.textContent = '';
            errorMessage.style.display = 'none';
        }

        errorText.textContent = '';

        // Clear the results list
        while (resultsList != null && resultsList.firstChild) {
            resultsList.removeChild(resultsList.firstChild);
        }
    });
});
