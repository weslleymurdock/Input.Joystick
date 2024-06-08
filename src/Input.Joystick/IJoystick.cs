namespace Input.Joystick;

public interface IJoystick
{
    event EventHandler<ButtonEventArgs> ButtonChanged;
    event EventHandler<AxisEventArgs> AxisChanged;        
}
