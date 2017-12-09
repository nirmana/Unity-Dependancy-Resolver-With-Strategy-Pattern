namespace Resolver
{
    public interface IRegisterComponent
    {
        /// <summary>
        /// Register type method
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="withInterception"></param>
        void RegisterType<TFrom, TTo>(bool withInterception = false) where TTo : TFrom;


        /// <summary>
        /// Register type method
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="key"></param>
        void RegisterType<TFrom, TTo>(string key) where TTo : TFrom;

        /// <summary>
        /// Register type with container controlled life time manager
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="withInterception"></param>
        void RegisterTypeWithControlledLifeTime<TFrom, TTo>(bool withInterception = false) where TTo : TFrom;
    }
}
