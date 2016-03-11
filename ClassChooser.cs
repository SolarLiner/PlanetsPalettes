using System;

namespace PlanettePalette
{
    public partial class Form1
    {
        private void TerraTab_Click(object sender, EventArgs e)
        {
            SelectedClass = Palette.PaletteClass.TERRA;
            RefreshBtn_Click(sender, e);
        }

        private void DesertTab_Click(object sender, EventArgs e)
        {
            SelectedClass = Palette.PaletteClass.DESERT;
            RefreshBtn_Click(sender, e);
        }

        private void OceaniaTab_Click(object sender, EventArgs e)
        {
            SelectedClass = Palette.PaletteClass.OCEANIA;
            RefreshBtn_Click(sender, e);
        }

        private void SelenaTab_Click(object sender, EventArgs e)
        {
            SelectedClass = Palette.PaletteClass.SELENA;
            RefreshBtn_Click(sender, e);
        }

        private void IceWldTab_Click(object sender, EventArgs e)
        {
            SelectedClass = Palette.PaletteClass.ICE_WORLD;
            RefreshBtn_Click(sender, e);
        }

        private void BrownDwarfTab_Click(object sender, EventArgs e)
        {
            SelectedClass = Palette.PaletteClass.BROWN_DWARF;
            RefreshBtn_Click(sender, e);
        }

        private void GasGntTab_Click(object sender, EventArgs e)
        {
            SelectedClass = Palette.PaletteClass.GAS_GIANT;
            RefreshBtn_Click(sender, e);
        }

        private void IceGntTab_Click(object sender, EventArgs e)
        {
            SelectedClass = Palette.PaletteClass.ICE_GIANT;
            RefreshBtn_Click(sender, e);
        }

        private void AsteroidTab_Click(object sender, EventArgs e)
        {
            SelectedClass = Palette.PaletteClass.ASTEROID;
            RefreshBtn_Click(sender, e);
        }

        private void TitanTab_Click(object sender, EventArgs e)
        {
            SelectedClass = Palette.PaletteClass.TITAN;
            RefreshBtn_Click(sender, e);
        }
    }
}