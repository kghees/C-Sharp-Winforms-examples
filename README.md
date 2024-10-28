# C-Sharp-Winforms-examples  

## listView,radiobutton example  
- radiobutton 5개에 listView의 모드 5개를 할당함
- Start(button1)클릭 시 End(button2) 활성화
![Untitled design (1)](https://github.com/user-attachments/assets/d38ac3ac-2583-4903-ab6a-4d10a41ee460)

## MaskedTextBox  
- MaskedTextBox 컨트롤은 TextBox에 입력 형식을 제한하는 기능을 추가한 컨트롤
- 속성 Mask에 입력 형식을 지정하는데, ex) 날짜 입력 0000.00.00
![Untitled design (2)](https://github.com/user-attachments/assets/a3b1ef92-d631-4334-b8ee-f1b5ef87b42c)

## Timer  
1. System.Windows.Forms.Timer
   - 사용자가 정의한 간격마다 이벤트를 발생시키는 타이머를 구현합니다. 이 타이머는 Windows Forms 응용 프로그램에서 사용할 수 있도록 최적화되었으며 창에서 사용해야 합니다. 
2. System.Threading.Timer
   - 지정된 간격으로 메서드를 실행하는 메커니즘을 제공합니다. 
3. System.Timers.Timer
   - 응용 프로그램에 되풀이 이벤트를 생성합니다.
     
![label2](https://github.com/user-attachments/assets/6f2f9b05-5a59-4f1f-975d-7f8acc0d2b81)
![image](https://github.com/user-attachments/assets/02b5ecdb-35fd-42b0-a692-5b08e09bd098)


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
![label1](https://github.com/user-attachments/assets/8a172962-abb9-41bd-9014-e58dfc5ea995)

## radiobutton  
- 다른 RadioButton 컨트롤과 함께 사용할 경우 사용자가 선택 그룹에서 단일 옵션을 선택할 수 있습니다.
![label1](https://github.com/user-attachments/assets/885d20d1-bc92-4d54-bfe1-4165b66a6c71)

## textBox  
- StringBuilder
   - 변경 가능한 문자열 Class
   - 문자 공간을 동적으로 확장
   - 문자열 변경 메서드
      - Append() : 문자열을 StringBuilder 객체의 끝에 추가합니다.
      - AppendLine() : 추가되는 문자열 끝에 개행 문자가 추가됩니다.
      - Insert() : 문자열을 지정된 인덱스에 삽입합니다.
      - Remove() : 지정된 인덱스에서 지정된 길이만큼 문자열을 삭제합니다.
      - Replace() : 지정된 문자열을 특정 문자열로 변경합니다.
![label1](https://github.com/user-attachments/assets/b9ae2813-76b2-4076-a712-3683d58c6441)

## richTextBox  
- 기본적인 사용 방법은 TextBox와 동일하지만 특정 문자에 대한 편집이 쉽고 표현이 풍부함
- txt파일은 PlainText 타입으로 적어주기
![button1](https://github.com/user-attachments/assets/00134355-34d4-43c1-a4a5-53add49827d6)

## Tooltip  
- SetToolTip(컨트롤, 메시지)이라는 메소드를 이용하면, 특정 컨트롤에 지정한 메시지를 보여줄 수 있음
- Tooltip컨트롤은 특정 컨트롤에 마우스를 올려 놓으면 간단한 도움말을 보여줄 때 쓰여지는 컨트롤
![Untitled design](https://github.com/user-attachments/assets/aede2162-07c1-4d3f-a1df-ef57064d46ec)

## TreeView Control    
- 계층적인 자료 구조를 나타내 주는 컨트롤
- 각 TreeView 아이템은 노드(Node)로 불리운다.
- Nodes 속성에 자식 노드들을 추가해서 계층적인 구조를 갖춘다.
![treeView1](https://github.com/user-attachments/assets/10accab3-91b1-4de7-9af2-d7f910d7b837)

## WebBroswer Control  
![image](https://github.com/user-attachments/assets/2e090d7c-146c-4840-ac5d-99aa481c2bcb)
![image](https://github.com/user-attachments/assets/d055cdeb-b339-42f2-a129-4b3b9eb69192)  

## BackgroundWorker Class  
- BackgroundWorker Class는 별도의 Thread에게 어떤 일을 시키기 위해 사용하는 Class이다.(비동기작업 헬퍼(Helper))
- UI Thread와 별도로 어떤 작업을 수행하는데 사용된다.
#### BackgroundWorker 피보나치 수열 합 구하기  
- 1부터 numbericUpDown에 입력한 숫자까지 피보나치 수열의 합을 구해주는 것
- 피보나치 수열이란?
  - F0 = 0, F1 = 1, Fn+2 = Fn + 1 + Fn
  - 첫째 및 둘째 항이 1이며 그 뒤의 모든 항은 바로 앞 두 항의 합인 수  
![Add a subheading](https://github.com/user-attachments/assets/c8890320-e213-4eb5-98dc-284bd818f5f3)
![image (1)](https://github.com/user-attachments/assets/64ef0675-b561-4e52-99f3-b7bfea3f6696)
![image (2)](https://github.com/user-attachments/assets/cbf65113-dcb0-408c-b33b-74960ff98210)
![image (3)](https://github.com/user-attachments/assets/62402e5b-ec50-42c9-9976-532a9b34f55f)
  
  **${\textsf{\color{red}출처}}$** - MSDN

## 동기/비동기 프로그래밍  
- 동기식
  - 작업이 수행되면 UI Thread가 정지 됨
  - 1초동안 UI Thread가 정지되기 때문에 창을 이동하거나 다른 작업을 수행할 수 없음
- 비동기식
  - 작업이 수행되어도 UI Thread가 정지되지 않음
- 동기 메서드
  - 차례로 2입력 후 3입력을 수행하니깐 "123" 출력
  - 작업을 수행하는 동안 프로그램을 이동하거나 다른 작업을 수행할 수 없음
- 비동기 메서드
  - 2입력 3입력을 동시에 수행하기 때문에 "132" 출력
  - 작업 수행동안 프로그램의 이동이나 다른 작업을 수행할 수 있음
![Add a subheading](https://github.com/user-attachments/assets/a203ac1c-0f78-4a6f-b55e-97e0836f0d76)
![image (1)](https://github.com/user-attachments/assets/c673aeda-399a-42ec-a887-b72fce1552e8)
![image (2)](https://github.com/user-attachments/assets/8a943a2f-2112-4bee-9127-e302de6ec83b)
![image (3)](https://github.com/user-attachments/assets/aae0e75a-022d-43e4-920a-3c4be601e0dc)
 **${\textsf{\color{red}출처}}$** - [MSDN](https://luvris2.tistory.com/559)

## Window MultiThreading  
- UI 컨트롤들을 갱신하기 위해서는 항상 해당 UI 컨트롤을 생성한 UI Thread에서 갱신하여야함
- UI Thread 이외의 Thread에서 Winform 내부의 컨트롤에 접근하여 수정할 수 없음
#### 다음은 Work Thread에서 랜덤 정수를 Winform control에 입력하는 예시이다.
![Add a subheading](https://github.com/user-attachments/assets/28441845-bc45-435b-8142-ac1f607ef6e0)

## System Tray  
- 컴퓨터 운영체제에서 사용자에게 현재 실행중인 프로그램이나 서비스 상태를 아이콘으로 표시하고, 간단한 상호작용을 할 수 있도록 제공하는 영역을 의미
- 주로 프로그램이 백그라운드에서 작업될 때 확인 및 제어하기 위해서 사용
- System Tray를 사용하는 이유
  - 시스템 상태 표시를 위해
    - 백그라운드로 실행되는 프로그램의 상태를 나타내 사용자가 프로그램을 확인하지 않고 손쉽게 프로그램의 상태를 확인 할 수 있다.
      ex) 와이파이 접속 상태 표시
  - 작업 표시줄의 깔끔한 관리를 위해
      - 현재 작업표시줄에서 사용하지 않는 프로그램을 숨기고 시스템 트레이 아이콘으로 표시 한다면, 사용자는 작업 표시줄을 보다 깨끗하게유지하면서 멀티 태스킹시 필요한 프로그램 접근을 보다 더 빠르게 할 수 있다.
  - 간단한 상호 작용을 위해
      - System Tray 아이콘을 클릭하여 빠르고 간단하게 특정 작업을 수행할 수 있다.
#### Form을 끄면 사용자가 설정한 아이콘으로 백그라운드창에서 실행되고 있다.  
![화면 캡처 2024-10-11 083040](https://github.com/user-attachments/assets/2a8fddd2-c906-4a17-8b22-fdf5d30d78a1)

 **${\textsf{\color{red}출처}}$**-https://luvris2.tistory.com/863  

## Chart Control  
- **Series :** 차트에서 데이터에 해당하는 X,Y 값들을 갖는 것이 Series
- **ChartArea :** 하나의 파트는 하나 이상의 CharaArea(차트영역)을 가질 수 있다. 일반적으로 한 Chart는 하나의 차트영역을 갖지만, 하나의 차트 컨트롤이 복수의 차트틀(ChartArea들)을 가질 수 있다.
- **Legends :** 범례에 해당하는 것으로 0개 이상의 범례를 가질 수 있고, 0개이면 범례가 표시X
- **Titles :** 차트 컨트롤 상단에 표시되는 제목으로 복수일 경우 위에서부터 한 라인씩 제목을 표시한다.
![image](https://github.com/user-attachments/assets/691c5a52-eee1-416e-b03e-07f8d4c9242b)
