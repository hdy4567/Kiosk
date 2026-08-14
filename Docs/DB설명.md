susi_orders_realtime.csv (실시간 진행 장부) 사용 탭: [1. 실시간 주문] 탭, [2. 테이블 현황] 탭 (결제 전)
역할: 현재 주방에서 조리 중이거나 홀에서 처리해야 할 활성화된 실시간 일감을 관리합니다.

구조 (컬럼):Identifier, Source, OrderType, OrderTime, TotalAmount, Status
Identifier: 키오스크는 그룹 ID(예: T02-01), 앱 주문은 영수증 번호(예: ORD-20260813-APP01) Source: 주문 출처 (키오스크, 앱) OrderType: 수령 방식 (매장, 포장, 배달) OrderTime: 주문 접수 시각 TotalAmount: 상세 품목들의 SubTotal을 모두 더한 최종 결제 예정 금액 Status: 진행 상태 (접수 대기, 조리 중, 조리 완료)

특징: 결제(키오스크) 또는 픽업/배달(앱)이 완료되면 이 파일에서 데이터가 삭제(이사)됩니다.
susi_sales_history.csv (매출 완료 장부) 사용 탭: [4. 과거 주문 내역] 탭, [7. 매출 리포트] 탭

역할: 처리가 완전히 끝나서 돈이 정산된 최종 매출 및 영수증 기록을 영구 보관합니다.
구조 (컬럼): ReceiptNo, PaymentDate, Source, OrderType, TotalAmount, PaymentMethod

ReceiptNo (영수증 번호): 고유 번호 (예: ORD-20260813-001 또는 앱 번호) PaymentDate: 결제 완료 시각 Source: 주문 출처 (키오스크, 앱) OrderType: 수령 방식 (매장, 포장, 배달) TotalAmount: 정가 총합 PaymentMethod: 결제 수단 (신용카드, 앱선결제 등)
💡 매출 계산 법: TotalAmount - Discount 값을 프로그램에서 계산하여 최종 매출액으로 활용합니다.
특징: realtime.csv에서 넘어온 데이터가 차곡차곡 쌓이며, 절대 삭제되지 않고 영구 보관됩니다.
susi_order_items.csv 구조 컬럼 구조: KeyId, MenuName, Price, Quantity, DiscountQty, SubTotal
KeyId: 매칭 키 (T02-01 또는 영수증 번호) MenuName: 메뉴 이름 (예: 광어초밥) Price: 단가 (예: 3000) Quantity: 총 주문 수량 (예: 3) DiscountQty: 그중 할인(무료) 적용된 수량 (예: 1) (여기에 추가!) SubTotal: 실제로 결제될 최종 금액 ((Quantity - DiscountQty) * Price, 예: (3 - 1) * 3000 = 6000원)
<1번 탭> 그리드 뷰: susi_orders_realtime.csv로 구성 주문 내역: susi_order_items.csv로 구성 -> Identifier == KeyId로 매칭하여 읽어옴.
<2번 탭> 주문 내역 (품목): susi_order_items.csv에서 테이블 이름(예: Table 02)과 매칭되는 KeyId(예: T02-01)의 모든 초밥 메뉴들을 불러와 화면에 표시. 결제 총 금액: susi_orders_realtime.csv 파일에서 해당 테이블의 식별자(Identifier, 예: T02-01)와 일치하는 행을 찾아 금액(총 결제액) 컬럼 값을 읽어와 하단이나 요약 영역에 띄워줌.
<4번 탭> 그리드 뷰: susi_sales_history.csv 파일에서 영수증 번호와 같은 KeyId로 읽어옴. 영수증 상세: susi_order_items.csv로 구성 → ReceiptNo == KeyId 조건으로 매칭.
<7번 탭> 매출, 건수: susi_sales_history.csv에서 집계. 메뉴 별 판매 건수, 할인된 금액: susi_order_items.csv에서 집계.
🛠 앞으로 구현해야 할 로직 (테이블 결제 완료/ 앱 주문 픽업 완료 시 트랜잭션 처리)
실시간 목록 제거: susi_orders_realtime.csv에서 해당 테이블의 내용(레코드)을 삭제.
매출 장부 추가: susi_sales_history.csv에 새로운 매출 내역(영수증 번호, 결제 일시, 금액 등)을 한 줄 추가.
상세 품목 식별자 갱신: susi_order_items.csv에 기록되어 있던 임시 테이블 식별자(예: T02-01)를 새로 발급된 영수증 번호로 수정(갱신)하여, 이후 4번과 7번 탭에서 정식 매출 데이터로 조회될 수 있도록 함.