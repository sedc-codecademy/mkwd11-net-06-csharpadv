namespace SEDC.AbstractClassesAndInterfaces.Domain.Intefaces
{
    // multiple inheritance in interface 
    public interface IFullStackDeveloper : IDeveloper, ITester
    {
        void DesignCode();
    }
}