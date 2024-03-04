<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="style.css">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>website UNi</title>
    <style>
        .onfromatin {
            background-color: #f2f2f2;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            max-width: 400px;
            margin: 0 auto;
        }

        .onfromatin p {
            font-size: 16px;
            margin-bottom: 5px;
        }

        .onfromatin input[type="text"],
        .onfromatin input[type="date"],
        .onfromatin input[type="number"] {
            width: calc(100% - 20px);
            padding: 10px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .onfromatin input[type="checkbox"] {
            margin-right: 5px;
        }

        .onfromatin button {
            background-color: #007bff;
            color: #fff;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
    </style>
</head>
<body>
    <div class="onfromatin">
        <p>: الاسم الكامل</p>
        <input type="text" id="namefull" readonly>
        <p>: العنوان</p>
        <input type="text" id="address" readonly>
        <p>: الشهادة</p>
        <input type="text" id="shada" readonly>
        <p>: الحالة الزوجية</p>
        <input type="checkbox" id="single" disabled> اعزب / عزباء
        <input type="checkbox" id="married" disabled> متزوج / متزوجة
        <input type="checkbox" id="widow" disabled> أرمل  / أرملة
        <p>: سنة التخرج</p>
        <input type="date" id="graduationYear" readonly>
        <p>: تاريخ</p>
        <input type="date" id="date" readonly>
        <p>: الرقم التعيين</p>
        <input type="number" id="number" readonly>
        <br>
        <button onclick="editForm()">تعديل</button>
        <button onclick="saveChanges()" style="display:none">حفظ التغييرات</button>
    </div>

    <script>
        function editForm() {
            var inputs = document.querySelectorAll("input");
            for (var i = 0; i < inputs.length; i++) {
                inputs[i].removeAttribute("readonly");
                inputs[i].removeAttribute("disabled");
            }
            document.getElementById("single").parentNode.style.pointerEvents = "auto";
            document.getElementById("married").parentNode.style.pointerEvents = "auto";
            document.getElementById("widow").parentNode.style.pointerEvents = "auto";

            document.querySelector("button").style.display = "none";
            document.querySelector("button:nth-of-type(2)").style.display = "block";
        }

        function saveChanges() {
            var inputs = document.querySelectorAll("input");
            for (var i = 0; i < inputs.length; i++) {
                inputs[i].setAttribute("readonly", true);
                inputs[i].setAttribute("disabled", true);
            }
            document.getElementById("single").parentNode.style.pointerEvents = "none";
            document.getElementById("married").parentNode.style.pointerEvents = "none";
            document.getElementById("widow").parentNode.style.pointerEvents = "none";

            document.querySelector("button").style.display = "block";
            document.querySelector("button:nth-of-type(2)").style.display = "none";
        }
    </script>
</body>
</html>
