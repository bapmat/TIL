# 응답시간
String > StringBuffer > StringBuilder


# 메모리
String >StringBuffer == StringBuilder


# String 클래스
- 한 번 생성되면 할당된 공간이 변하지 않는다. -> ***불변 immutable***
- 문자열 연산이 적고 멀티스레드 환경일 경우
```c#
String s = "data";
s += "plus";
```
- 문자열 연산(추가, 삭제) 작업 시 비효율적 -> 실행 속도와 메모리 사용 문제가 발생한다.

> 📌 C# String과 string의 차이<br>
String는 System 네임스페이스에 속한 자료형으로 정확한 표현은 ***System.String***이다.<br/>
using System; 문장을 이용하면 String로 표기해도 된다.<br/>
string은 ***System.String***의 별칭?


# StringBuilder 클래스, StringBuffer 클래스
1. StringBuilder
- 단일 스레스 환경에서만 사용하도록 설계(NOT Thread-safe)
- 문자열 연산이 많고 단일 스레드이거나 동기화를 고려하지 않아도 되는 경우

2. StringBuffer
- 멀티 스레드 환경에서 동기화를 지원[^note1] (Thread-safe)
- 힙 메모리[^note2]에 적재
- 문자열 연산(추가, 삭제)이 많고 멀티 스레드 환경일 경우

3. 특징
- 객체의 공간이 부족해지는 경우 버퍼의 크기를 유연하게 늘려준다. -> ***가변 mutable***
- 값이 자주 변경되는 경우 사용하는 것이 좋다.

---

```
업무를 진행할 때 늘 string만 사용했었음
하여 string이 메모리 문제나 실행 속도에 문제가 있는 줄은 몰랐음
이번에 공부하면서 보니 stringbuilder 좋은데 모르는 사람이 많다고 하네
```


# 참고
https://1-day-1-coding.tistory.com/54<br/>
https://beforb.tistory.com/32<br/>
https://velog.io/@doghqkr13/String-StringBuilder-StringBuffer<br/>
https://aomee0880.tistory.com/150<br/>
https://hahahoho5915.tistory.com/36<br/>
https://coding-factory.tistory.com/546<br/>
https://basement142.tistory.com/9<br/>
https://sualchi.tistory.com/13720500

[^note1]: 동기화를 지원한다?<br/>
여러 스레드가 한 자원을 사용하려고 할 때 다른 스레드의 접근을 막는 것 = 멀티스레드 환경을 지원

[^note2]: 가비지 컬렉션이 동작하는 영역
