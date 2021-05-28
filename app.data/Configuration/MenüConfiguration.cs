using app.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace app.data.Configuration
{
    public class MenüConfiguration : IEntityTypeConfiguration<Menü>
    {
        public void Configure(EntityTypeBuilder<Menü> builder)
        {
            builder.HasData(

                new Menü(){Id=1,Gived1=false,Gived2=false,Gived3=false,Gived4=false,Gived5=false,Gived6=false,Gived7=false,Gived8=false,MenüName1="menü1",MenüName2="menü2",MenüName3="menü3",MenüName4="menü4",MenüName5="menü5",MenüName6="menü6",MenüName7="menü7",MenüName8="menü8"},
                new Menü(){Id=2,Gived1=true,Gived2=false,Gived3=false,Gived4=false,Gived5=false,Gived6=false,Gived7=false,Gived8=false,MenüName1="menü1",MenüName2="menü2",MenüName3="menü3",MenüName4="menü4",MenüName5="menü5",MenüName6="menü6",MenüName7="menü7",MenüName8="menü8"},
                new Menü(){Id=3,Gived1=true,Gived2=false,Gived3=false,Gived4=false,Gived5=false,Gived6=false,Gived7=false,Gived8=false,MenüName1="menü1",MenüName2="menü2",MenüName3="menü3",MenüName4="menü4",MenüName5="menü5",MenüName6="menü6",MenüName7="menü7",MenüName8="menü8"},
                new Menü(){Id=4,Gived1=false,Gived2=true,Gived3=false,Gived4=false,Gived5=false,Gived6=false,Gived7=false,Gived8=false,MenüName1="menü1",MenüName2="menü2",MenüName3="menü3",MenüName4="menü4",MenüName5="menü5",MenüName6="menü6",MenüName7="menü7",MenüName8="menü8"},
                new Menü(){Id=5,Gived1=false,Gived2=false,Gived3=true,Gived4=false,Gived5=false,Gived6=false,Gived7=false,Gived8=false,MenüName1="menü1",MenüName2="menü2",MenüName3="menü3",MenüName4="menü4",MenüName5="menü5",MenüName6="menü6",MenüName7="menü7",MenüName8="menü8"},
                new Menü(){Id=6,Gived1=false,Gived2=false,Gived3=false,Gived4=false,Gived5=false,Gived6=false,Gived7=false,Gived8=false,MenüName1="menü1",MenüName2="menü2",MenüName3="menü3",MenüName4="menü4",MenüName5="menü5",MenüName6="menü6",MenüName7="menü7",MenüName8="menü8"},
                new Menü(){Id=7,Gived1=false,Gived2=true,Gived3=false,Gived4=true,Gived5=false,Gived6=false,Gived7=false,Gived8=false,MenüName1="menü1",MenüName2="menü2",MenüName3="menü3",MenüName4="menü4",MenüName5="menü5",MenüName6="menü6",MenüName7="menü7",MenüName8="menü8"}
            );
        }
    }
}