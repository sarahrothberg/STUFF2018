//instead of deriving from MonoBehaviour, this is class is namespaced so it can be referenced in other class
namespace StateNamespace
{
	//the <T> means that any type can use this statemachine
	public class StateMachine<T>
	{
		public State<T> currentState { get; private set; }
		//below is the object that will use the statemachine
		public T Owner;

		//pass in an object of type owner
		public StateMachine(T _o)
		{
			Owner = _o;
			currentState = null;
		}

		public void ChangeState(State<T> _newstate)
		{
			if (currentState != null)
				currentState.ExitState(Owner);
			currentState = _newstate;
			currentState.EnterState(Owner);
		}

		public void Update()
		{
			if (currentState != null)
				currentState.UpdateState(Owner);
		}
	}
	public abstract class State<T>
	{
		public abstract void EnterState(T _mainController);
		public abstract void ExitState(T _mainController);
		public abstract void UpdateState(T _mainController);
	}
}