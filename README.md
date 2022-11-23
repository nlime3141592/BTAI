# BTAI
Behavior Tree로 AI를 구현합니다. Behavior Tree 소스 코드는 `BehaviorTree.cs`, `Node.cs`, `CompositeNode.cs`, `SequenceNode.cs`, `SelectorNode.cs` 파일을 참조하세요.

## 설계 방식
AI는 센서로 세계를 인식하고 인식 정보를 기억합니다. 인식 정보를 AI의 행동 결정 알고리즘에 입력하면 AI는 다음 상황에 어떤 행동을 할지 결정합니다.
위 설명에 따라서 AI가 수행할 수 있는 모든 동작을 몇 가지 기준에 맞게 분류하고, 해당 기준을 Behavior Tree의 차상위 Node로 설정하였습니다. 기준은 아래와 같습니다.
- 인식(Recognization)
- 조건 판단(Condition)
- 의미단위의 값 할당 또는 변경(Assignment)
- 동작 수행(Action)

따라서 Node의 하위 클래스로 `RecognizationNode`, `ConditionNode`, `AssignmentNode`, `ActionNode`가 존재합니다. 세부 노드는 모두 차상위 Node로부터 파생됩니다.
자세한 내용은 `RecognizationNode.cs`, `ConditionNode.cs`, `AssignmentNode.cs`, `ActionNode.cs`를 참조하세요.

## 지형 탐지 예시
현재 Entity는 몇 가지 정해진 지형 정보를 정해진 로직에 따라 판단할 수 있습니다. Behavior Tree로 탐색 로직을 구성하였습니다. 지형 정보를 판단하는 규칙은 아래와 같습니다.
자세한 내용은 `Entity.cs` 파일을 참조하세요.
- 몇 가지 정해진 지형 정보: 바닥, 벽, 난간, 절벽
- 바닥: 항상 탐색함
- 절벽: 바닥이 있을 경우에만 탐색함
- 난간: 바닥이 없을 경우에만 탐색함
- 벽: 바닥이 없고 난간이 없을 경우에만 탐색함

각 지형 정보를 인식하는 방법을 자세히 확인하려면 아래 파일을 참조하세요.
- `Entity.cs`
- `TerrainManager.cs`
- `FloorRecognizationNode.cs`
- `LedgeRecognizationNode.cs`
- `CliffRecognizationNode.cs`
- `WallRecognizationNode.cs`
- `FloorRecognizationData.cs`
- `LedgeRecognizationData.cs`
- `CliffRecognizationData.cs`
- `WallRecognizationData.cs`

## Pulse Module 예시
Pulse Module은 Entity.FC 변수가 일정 수치에 도달했을 때 0으로 만들어주는 테스트 모듈입니다. 자세한 내용은 `PulseModule.cs` 파일을 참조하세요.
