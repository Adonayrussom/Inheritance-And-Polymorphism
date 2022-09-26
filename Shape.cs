namespace sess07_inheritance_and_polymorphism
{
    /// <summary>
    /// Abstract class that will be used as the base class for all shapes
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Method used to obtain the measurement/dimensions of the shape in cm
        /// </summary>
        /// <returns>An unsigned integer array of the shape's dimension in cm</returns>
        public abstract uint[] GetDimension();
    }
}