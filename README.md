# C-Sharp-Winforms-examples  

## listView,radiobutton example  
- radiobutton 5개에 listView의 모드 5개를 할당함
- Start(button1)클릭 시 End(button2) 활성화
![Untitled design (1)](https://github.com/user-attachments/assets/d38ac3ac-2583-4903-ab6a-4d10a41ee460)

## MaskedTextBox  
- MaskedTextBox 컨트롤은 TextBox에 입력 형식을 제한하는 기능을 추가한 컨트롤
- 속성 Mask에 입력 형식을 지정하는데, ex) 날짜 입력 0000.00.00
![Untitled design (2)](https://github.com/user-attachments/assets/a3b1ef92-d631-4334-b8ee-f1b5ef87b42c)

## MonthCalendar, DatetimePicker  
- 하루이상의 날짜가 필요할 땐 MonthCalendar를 하루만 필요할 땐 DateTimePicker를 쓰면된다.
![label1](https://github.com/user-attachments/assets/5ef7c5f8-99e5-4c23-9022-e23889703c96)

## NumericUpDown  
- c#에서 실수를 저장할 수 있는 변수로 **${\textsf{\color{red}double}}$** **${\textsf{\color{red}decimal}}$** 이 자주 사용됨
- double
  - 부동소수점 방식
  - 64비트(8바이트)크기에, 약 15~16자리의 유효숫자를 가짐
  - decimal에 비해 연산이 빠르기에 대두분의 경우 사용됨
- decimal
  - 고정소수점 방식
  - 128비트(16바이트)크기에 28~29자리의 유효숫자를 가짐
  - 정밀한 계산이 필요한 금융, 세금, 과학 등의 분야에서 사용
  - M을 뒤에 붙이는 것은 decimal 타입이라는 것을 명시하기 위함임
![label1](https://github.com/user-attachments/assets/7423b348-65d1-4b7d-bd22-500c83d88fbb)

## PictureBox  
- Normal
   - 원본 이미지를 컨트롤 크기 만큼만 보여줌
- CenterImage
   - 컨트롤 크기와 이미지 크기가 다를 경우, 원본 이미지의 중앙 부분을 기준으로 컨트롤 크기만큼만 보여줌
- AutoSize
   - 컨트롤 크기가 원본 이미지 크기로 자동으로 변경됨. 원본 이미지 전체를 그대로 보여준다.
- StretchImage
   - 원본 이미지의 가로/세로를 확대 또는 축소해서 컨트롤에 꽉 채워서 출력함
- Zoom
   - 원본 이미지를 확대/축소해서 컨트롤에 보여줌. 원본 이미지의 가로/세로 비율이 그대로 유지된다.
![label1](https://github.com/user-attachments/assets/7ec40338-9a63-4875-b331-82334708a6e7)

