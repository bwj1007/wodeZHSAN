﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using GameGlobal;
using Microsoft.Xna.Framework.Graphics;
using GameFreeText;
using GameObjects;

namespace ArchitectureSurveyPlugin
{
    internal class ArchitectureSurvey
    {
        public FreeText AgricultureText;
        public Architecture ArchitectureToSurvey;
        public FreeText ArmyText;
        public Point BackgroundSize;
        public Texture2D BackgroundTexture;
        public FreeText CommerceText;
        private bool Controlling;
        public Point ControllingBackgroundSize;
        public Texture2D ControllingBackgroundTexture;
        public Point CurrentPosition;
        private Point displayOffset;
        public FreeText DominationText;
        public FreeText EnduranceText;
        public Color FactionColor;
        public Rectangle FactionPosition;
        public FreeText FactionText;
        public Texture2D FactionTexture;
        public FreeText FoodText;
        public FreeText FundText;
        public FreeText KindText;
        public int Left;
        public InformationLevel Level;
        public FreeText MoraleText;
        public FreeText NameText;
        public FreeText NoFactionPersonCountText;
        public FreeText PersonCountText;
        public FreeText PopulationText;
        public FreeText MilitaryPopulationText;
        public FreeText FacilityCountText;
        public FreeText BuildingDaysLeftText;
        public FreeText MayorNameText;
        public FreeText TechnologyText;
        public int Top;
        public Faction ViewingFaction;

        //↓功能开关定义
        internal string Switch1;//建筑种类图片
        internal string Switch2;//进度条图片

        //↓建筑种类相关定义
        internal string AKinds;
        internal string AKindfor1;
        internal string AKindfor2;
        internal string AKindfor3;
        internal string AKindfor4;
        internal string AKindfor5;
        internal string AKindfor6;
        internal string AKindfor7;
        internal string AKindfor8;
        internal string AKindfor9;
        internal string AKindfor10;
        internal string AKindfor11;
        internal string AKindfor12;
        internal string AKindfor13;
        internal string AKindfor14;
        internal string AKindfor15;
        internal string AKindfor16;
        internal string AKindfor17;
        internal string AKindfor18;
        internal string AKindfor19;
        internal string AKindfor20;
        internal string AKindfor21;
        internal string AKindfor22;
        internal string AKindfor23;
        internal string AKindfor24;
        internal string AKindfor25;
        internal string AKindfor26;
        internal string AKindfor27;
        internal string AKindfor28;
        //↓建筑种类文理及尺寸相关定义
        internal Texture2D AKBackgroundTexture;
        internal Texture2D AKBackground0Texture;
        internal Texture2D AKBackground1Texture;
        internal Texture2D AKBackground2Texture;
        internal Texture2D AKBackground3Texture;
        internal Texture2D AKBackground4Texture;
        internal Texture2D AKBackground5Texture;
        internal Texture2D AKBackground6Texture;
        internal Texture2D AKBackground7Texture;
        internal Texture2D AKBackground8Texture;
        internal Texture2D AKBackground9Texture;
        internal Texture2D AKBackground10Texture;
        internal Texture2D AKBackground11Texture;
        internal Texture2D AKBackground12Texture;
        internal Texture2D AKBackground13Texture;
        internal Texture2D AKBackground14Texture;
        internal Texture2D AKBackground15Texture;
        internal Texture2D AKBackground16Texture;
        internal Texture2D AKBackground17Texture;
        internal Texture2D AKBackground18Texture;
        internal Texture2D AKBackground19Texture;
        internal Texture2D AKBackground20Texture;
        internal Texture2D AKBackground21Texture;
        internal Texture2D AKBackground22Texture;
        internal Texture2D AKBackground23Texture;
        internal Texture2D AKBackground24Texture;
        internal Texture2D AKBackground25Texture;
        internal Texture2D AKBackground26Texture;
        internal Texture2D AKBackground27Texture;
        internal Texture2D AKBackground28Texture;
        internal Rectangle AKBackground0Client; 
        //进度条相关定义
        internal Texture2D ArmyBarTexture;
        internal Texture2D Army1BarTexture;
        internal Texture2D Army2BarTexture;
        internal Texture2D Army3BarTexture;
        internal Texture2D Army4BarTexture;
        internal Texture2D Army5BarTexture;
        internal Texture2D Army6BarTexture;
        internal Rectangle ArmyBarClient;

        internal Texture2D DominationBarTexture;
        internal Texture2D Domination1BarTexture;
        internal Texture2D Domination2BarTexture;
        internal Texture2D Domination3BarTexture;
        internal Texture2D Domination4BarTexture;
        internal Texture2D Domination5BarTexture;
        internal Texture2D Domination6BarTexture;
        internal Rectangle DominationBarClient;

        internal Texture2D EnduranceBarTexture;
        internal Texture2D Endurance1BarTexture;
        internal Texture2D Endurance2BarTexture;
        internal Texture2D Endurance3BarTexture;
        internal Texture2D Endurance4BarTexture;
        internal Texture2D Endurance5BarTexture;
        internal Texture2D Endurance6BarTexture;
        internal Rectangle EnduranceBarClient;

        internal Texture2D AgricultureBarTexture;
        internal Texture2D Agriculture1BarTexture;
        internal Texture2D Agriculture2BarTexture;
        internal Texture2D Agriculture3BarTexture;
        internal Texture2D Agriculture4BarTexture;
        internal Texture2D Agriculture5BarTexture;
        internal Texture2D Agriculture6BarTexture;
        internal Rectangle AgricultureBarClient;

        internal Texture2D CommerceBarTexture;
        internal Texture2D Commerce1BarTexture;
        internal Texture2D Commerce2BarTexture;
        internal Texture2D Commerce3BarTexture;
        internal Texture2D Commerce4BarTexture;
        internal Texture2D Commerce5BarTexture;
        internal Texture2D Commerce6BarTexture;
        internal Rectangle CommerceBarClient;

        internal Texture2D TechnologyBarTexture;
        internal Texture2D Technology1BarTexture;
        internal Texture2D Technology2BarTexture;
        internal Texture2D Technology3BarTexture;
        internal Texture2D Technology4BarTexture;
        internal Texture2D Technology5BarTexture;
        internal Texture2D Technology6BarTexture;
        internal Rectangle TechnologyBarClient;

        internal Texture2D MoraleBarTexture;
        internal Texture2D Morale1BarTexture;
        internal Texture2D Morale2BarTexture;
        internal Texture2D Morale3BarTexture;
        internal Texture2D Morale4BarTexture;
        internal Texture2D Morale5BarTexture;
        internal Texture2D Morale6BarTexture;
        internal Rectangle MoraleBarClient;

        internal Texture2D FacilityCountBarTexture;
        internal Texture2D FacilityCount1BarTexture;
        internal Texture2D FacilityCount2BarTexture;
        internal Texture2D FacilityCount3BarTexture;
        internal Texture2D FacilityCount4BarTexture;
        internal Texture2D FacilityCount5BarTexture;
        internal Texture2D FacilityCount6BarTexture;
        internal Rectangle FacilityCountBarClient;

        float Bar1 = 0;
        float Bar2 = 0;
        float Bar3 = 0;
        float Bar4 = 0;
        float Bar5 = 0;
        float Bar6 = 0;
        float Bar7 = 0;
        float Bar8 = 0;
        


        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle? nullable;
            if (!this.Controlling)
            {
                nullable = null;
                spriteBatch.Draw(this.BackgroundTexture, new Rectangle(this.displayOffset.X, this.displayOffset.Y, this.BackgroundSize.X, this.BackgroundSize.Y), nullable, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0.053f);
                spriteBatch.Draw(this.FactionTexture, new Rectangle(this.displayOffset.X + this.FactionPosition.X, this.displayOffset.Y + this.FactionPosition.Y, this.FactionPosition.Width, this.FactionPosition.Height), null, this.FactionColor, 0f, Vector2.Zero, SpriteEffects.None, 0.049f);
                this.NameText.Draw(spriteBatch, 0.05f);
                this.KindText.Draw(spriteBatch, 0.05f);
                this.FactionText.Draw(spriteBatch, 0.05f);
                this.PopulationText.Draw(spriteBatch, 0.05f);
                this.MilitaryPopulationText.Draw(spriteBatch, 0.05f);
                this.ArmyText.Draw(spriteBatch, 0.05f);
                this.DominationText.Draw(spriteBatch, 0.05f);
                this.EnduranceText.Draw(spriteBatch, 0.05f);
                this.MayorNameText.Draw(spriteBatch, 0.05f);
            }
            else
            {
                nullable = null;
                spriteBatch.Draw(this.ControllingBackgroundTexture, new Rectangle(this.displayOffset.X, this.displayOffset.Y, this.ControllingBackgroundSize.X, this.ControllingBackgroundSize.Y), nullable, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0.053f);
                spriteBatch.Draw(this.FactionTexture, new Rectangle(this.displayOffset.X + this.FactionPosition.X, this.displayOffset.Y + this.FactionPosition.Y, this.FactionPosition.Width, this.FactionPosition.Height), null, this.FactionColor, 0f, Vector2.Zero, SpriteEffects.None, 0.052f);
                if (Switch1 == "1")
                {
                    spriteBatch.Draw(this.AKBackgroundTexture, this.AKBackgroundDisplayPosition, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0.0491f);
                }
                if (Switch2 == "1")
                {
                    spriteBatch.Draw(this.ArmyBarTexture, this.ArmyBarDisplayPosition, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0.051f);
                    spriteBatch.Draw(this.DominationBarTexture, this.DominationBarDisplayPosition, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0.051f);
                    spriteBatch.Draw(this.EnduranceBarTexture, this.EnduranceBarDisplayPosition, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0.051f);
                    spriteBatch.Draw(this.AgricultureBarTexture, this.AgricultureBarDisplayPosition, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0.051f);
                    spriteBatch.Draw(this.CommerceBarTexture, this.CommerceBarDisplayPosition, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0.051f);
                    spriteBatch.Draw(this.TechnologyBarTexture, this.TechnologyBarDisplayPosition, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0.051f);
                    spriteBatch.Draw(this.MoraleBarTexture, this.MoraleBarDisplayPosition, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0.051f);
                    spriteBatch.Draw(this.FacilityCountBarTexture, this.FacilityCountBarDisplayPosition, null, Color.White, 0f, Vector2.Zero, SpriteEffects.None, 0.051f);
                }

                this.NameText.Draw(spriteBatch, 0.05f);
                this.KindText.Draw(spriteBatch, 0.05f);
                this.FactionText.Draw(spriteBatch, 0.05f);
                this.PopulationText.Draw(spriteBatch, 0.05f);
                this.MilitaryPopulationText.Draw(spriteBatch, 0.05f);
                this.ArmyText.Draw(spriteBatch, 0.05f);
                this.DominationText.Draw(spriteBatch, 0.05f);
                this.EnduranceText.Draw(spriteBatch, 0.05f);
                this.FundText.Draw(spriteBatch, 0.05f);
                this.FoodText.Draw(spriteBatch, 0.05f);
                this.PersonCountText.Draw(spriteBatch, 0.05f);
                this.FacilityCountText.Draw(spriteBatch, 0.05f);
                this.NoFactionPersonCountText.Draw(spriteBatch, 0.05f);
                this.AgricultureText.Draw(spriteBatch, 0.05f);
                this.CommerceText.Draw(spriteBatch, 0.05f);
                this.TechnologyText.Draw(spriteBatch, 0.05f);
                this.MoraleText.Draw(spriteBatch, 0.05f);
                this.BuildingDaysLeftText.Draw(spriteBatch, 0.05f);
                this.MayorNameText.Draw(spriteBatch, 0.05f);
            }
        }

        private void ResetTextsPosition()
        {
            this.NameText.DisplayOffset = this.displayOffset;
            this.KindText.DisplayOffset = this.displayOffset;
            this.FactionText.DisplayOffset = this.displayOffset;
            this.PopulationText.DisplayOffset = this.displayOffset;
            this.MilitaryPopulationText.DisplayOffset = this.displayOffset;
            this.ArmyText.DisplayOffset = this.displayOffset;
            this.DominationText.DisplayOffset = this.displayOffset;
            this.EnduranceText.DisplayOffset = this.displayOffset;
            this.FundText.DisplayOffset = this.displayOffset;
            this.FoodText.DisplayOffset = this.displayOffset;
            this.PersonCountText.DisplayOffset = this.displayOffset;
            this.FacilityCountText.DisplayOffset = this.displayOffset;
            this.NoFactionPersonCountText.DisplayOffset = this.displayOffset;
            this.AgricultureText.DisplayOffset = this.displayOffset;
            this.CommerceText.DisplayOffset = this.displayOffset;
            this.TechnologyText.DisplayOffset = this.displayOffset;
            this.MoraleText.DisplayOffset = this.displayOffset;
            this.BuildingDaysLeftText.DisplayOffset = this.displayOffset;
            this.MayorNameText.DisplayOffset = this.displayOffset;
        }

        public void Update()
        {
            Rectangle rectangle;
            this.FactionColor = Color.White;
            string meigongzuoderenshuzifuchuan;
            if (this.ArchitectureToSurvey.BelongedFaction != null)
            {
                this.FactionColor = this.ArchitectureToSurvey.BelongedFaction.FactionColor;
            }
            if (((this.ViewingFaction != null) && !GlobalVariables.SkyEye) && (this.ViewingFaction != this.ArchitectureToSurvey.BelongedFaction))
            {
                this.Controlling = false;
                rectangle = new Rectangle(this.Left - this.BackgroundSize.X, this.Top - this.BackgroundSize.Y, this.BackgroundSize.X, this.BackgroundSize.Y);
                StaticMethods.AdjustRectangleInViewport(ref rectangle);
                this.DisplayOffset = new Point(rectangle.X, rectangle.Y);
                this.NameText.Text = this.ArchitectureToSurvey.Name;
                this.KindText.Text = this.ArchitectureToSurvey.KindString;
                this.FactionText.Text = this.ArchitectureToSurvey.FactionString;
                this.PopulationText.Text = this.ArchitectureToSurvey.PopulationInInformationLevel(this.Level);
                this.MilitaryPopulationText.Text = this.ArchitectureToSurvey.MilitaryPopulationInInformationLevel(this.Level);
                //this.ArmyText.Text = this.ArchitectureToSurvey.ArmyQuantityInInformationLevel(this.Level);

                //////////////////////////////////////////////////////////临时代码 ，合理的应该恢复上句并修改GameObjects.Architecture
                if (this.Level == InformationLevel.未知 || this.Level == InformationLevel.无 || this.Level == InformationLevel.低)
                {
                    this.ArmyText.Text = this.ArchitectureToSurvey.ArmyQuantityInInformationLevel(this.Level);
                }
                else
                {
                    this.ArmyText.Text = this.ArchitectureToSurvey.MilitaryCount.ToString() + "/" + this.ArchitectureToSurvey.ArmyQuantity.ToString();

                }
                /////////////////////////////////////////////////////////////
                this.DominationText.Text = this.ArchitectureToSurvey.DominationInInformationLevel(this.Level);
                this.EnduranceText.Text = this.ArchitectureToSurvey.EnduranceInInformationLevel(this.Level);
                this.MayorNameText.Text = this.ArchitectureToSurvey.MayorName;
            }
            else
            {
                this.Controlling = true;
                rectangle = new Rectangle(this.Left - this.ControllingBackgroundSize.X, this.Top - this.ControllingBackgroundSize.Y, this.ControllingBackgroundSize.X, this.ControllingBackgroundSize.Y);
                StaticMethods.AdjustRectangleInViewport(ref rectangle);
                meigongzuoderenshuzifuchuan = meigongzuoderenshu(this.ArchitectureToSurvey).ToString();

                this.DisplayOffset = new Point(rectangle.X, rectangle.Y);
                this.NameText.Text = this.ArchitectureToSurvey.Name;
                this.KindText.Text = this.ArchitectureToSurvey.KindString;
                this.FactionText.Text = this.ArchitectureToSurvey.FactionString;
                this.PopulationText.Text = this.ArchitectureToSurvey.Population.ToString();
                this.MilitaryPopulationText.Text = this.ArchitectureToSurvey.MilitaryPopulation.ToString();
                this.ArmyText.Text = this.ArchitectureToSurvey.MilitaryCount.ToString() + "/" + this.ArchitectureToSurvey.ArmyQuantity.ToString();
                this.DominationText.Text = this.ArchitectureToSurvey.DominationString;
                this.EnduranceText.Text = this.ArchitectureToSurvey.EnduranceString;
                this.FundText.Text = this.ArchitectureToSurvey.Fund.ToString();
                if (this.ArchitectureToSurvey.Food < 10000)
                {
                    this.FoodText.Text = (this.ArchitectureToSurvey.Food / 10000.0f).ToString("f1") + "万";

                }
                else
                {
                    this.FoodText.Text = Math.Floor(this.ArchitectureToSurvey.Food / 10000.0f).ToString() + "万";
                }
                this.PersonCountText.Text = meigongzuoderenshuzifuchuan + "/" + this.ArchitectureToSurvey.PersonCount.ToString();
                this.FacilityCountText.Text = this.ArchitectureToSurvey.SheshiMiaoshu;
                this.NoFactionPersonCountText.Text = this.ArchitectureToSurvey.NoFactionPersonCount.ToString();
                this.AgricultureText.Text = this.ArchitectureToSurvey.AgricultureString;
                this.CommerceText.Text = this.ArchitectureToSurvey.CommerceString;
                this.TechnologyText.Text = this.ArchitectureToSurvey.TechnologyString;
                this.MoraleText.Text = this.ArchitectureToSurvey.MoraleString;
                this.BuildingDaysLeftText.Text = this.ArchitectureToSurvey.BuildingDaysLeft.ToString();
                this.MayorNameText.Text = this.ArchitectureToSurvey.MayorName;
                //↓判断建筑种类对应文理
                if (Switch1 == "1")
                {
                    AKinds = this.ArchitectureToSurvey.KindString;
                    if (AKinds == AKindfor1)
                    {
                        AKBackgroundTexture = AKBackground1Texture;
                    }

                    else if (AKinds == AKindfor2)
                    {
                        AKBackgroundTexture = AKBackground2Texture;
                    }
                    else if (AKinds == AKindfor3)
                    {
                        AKBackgroundTexture = AKBackground3Texture;
                    }
                    else if (AKinds == AKindfor4)
                    {
                        AKBackgroundTexture = AKBackground4Texture;
                    }
                    else if (AKinds == AKindfor5)
                    {
                        AKBackgroundTexture = AKBackground5Texture;
                    }
                    else if (AKinds == AKindfor6)
                    {
                        AKBackgroundTexture = AKBackground6Texture;
                    }
                    else if (AKinds == AKindfor7)
                    {
                        AKBackgroundTexture = AKBackground7Texture;
                    }
                    else if (AKinds == AKindfor8)
                    {
                        AKBackgroundTexture = AKBackground8Texture;
                    }
                    else if (AKinds == AKindfor9)
                    {
                        AKBackgroundTexture = AKBackground9Texture;
                    }
                    else if (AKinds == AKindfor10)
                    {
                        AKBackgroundTexture = AKBackground10Texture;
                    }
                    else if (AKinds == AKindfor11)
                    {
                        AKBackgroundTexture = AKBackground11Texture;
                    }
                    else if (AKinds == AKindfor12)
                    {
                        AKBackgroundTexture = AKBackground12Texture;
                    }
                    else if (AKinds == AKindfor13)
                    {
                        AKBackgroundTexture = AKBackground13Texture;
                    }
                    else if (AKinds == AKindfor14)
                    {
                        AKBackgroundTexture = AKBackground14Texture;
                    }
                    else if (AKinds == AKindfor15)
                    {
                        AKBackgroundTexture = AKBackground15Texture;
                    }
                    else if (AKinds == AKindfor16)
                    {
                        AKBackgroundTexture = AKBackground16Texture;
                    }
                    else if (AKinds == AKindfor17)
                    {
                        AKBackgroundTexture = AKBackground17Texture;
                    }
                    else if (AKinds == AKindfor18)
                    {
                        AKBackgroundTexture = AKBackground18Texture;
                    }
                    else if (AKinds == AKindfor19)
                    {
                        AKBackgroundTexture = AKBackground19Texture;
                    }
                    else if (AKinds == AKindfor20)
                    {
                        AKBackgroundTexture = AKBackground20Texture;
                    }

                    else if (AKinds == AKindfor21)
                    {
                        AKBackgroundTexture = AKBackground21Texture;
                    }
                    else if (AKinds == AKindfor22)
                    {
                        AKBackgroundTexture = AKBackground22Texture;
                    }
                    else if (AKinds == AKindfor23)
                    {
                        AKBackgroundTexture = AKBackground23Texture;
                    }
                    else if (AKinds == AKindfor24)
                    {
                        AKBackgroundTexture = AKBackground24Texture;
                    }
                    else if (AKinds == AKindfor25)
                    {
                        AKBackgroundTexture = AKBackground25Texture;
                    }
                    else if (AKinds == AKindfor26)
                    {
                        AKBackgroundTexture = AKBackground26Texture;
                    }
                    else if (AKinds == AKindfor27)
                    {
                        AKBackgroundTexture = AKBackground27Texture;
                    }
                    else if (AKinds == AKindfor28)
                    {
                        AKBackgroundTexture = AKBackground28Texture;
                    }
                    else
                    {
                        AKBackgroundTexture = AKBackground0Texture;
                    }
                }
                //↓进度条对应文理
                if (Switch2 == "1")
                {
                    if (this.ArchitectureToSurvey.MilitaryCount == 0 || this.ArchitectureToSurvey.ArmyQuantity == 0)
                    {
                        Bar1 = 0;
                    }
                    else
                    {
                        Bar1 = 100 * this.ArchitectureToSurvey.MilitaryCount / this.ArchitectureToSurvey.ArmyQuantity;
                    }
                    if (this.ArchitectureToSurvey.Domination == 0 || this.ArchitectureToSurvey.DominationCeiling == 0)
                    {
                        Bar2 = 0;
                    }
                    else
                    {
                        Bar2 = 100 * this.ArchitectureToSurvey.Domination / this.ArchitectureToSurvey.DominationCeiling;
                    }
                    if (this.ArchitectureToSurvey.Endurance == 0 || this.ArchitectureToSurvey.EnduranceCeiling == 0)
                    {
                        Bar3 = 0;
                    }
                    else
                    {
                        Bar3 = 100 * this.ArchitectureToSurvey.Endurance / this.ArchitectureToSurvey.EnduranceCeiling;
                    }
                    if (this.ArchitectureToSurvey.Agriculture == 0 || this.ArchitectureToSurvey.AgricultureCeiling == 0)
                    {
                        Bar4 = 0;
                    }
                    else
                    {
                        Bar4 = 100 * this.ArchitectureToSurvey.Agriculture / this.ArchitectureToSurvey.AgricultureCeiling;
                    }
                    if (this.ArchitectureToSurvey.Commerce == 0 || this.ArchitectureToSurvey.CommerceCeiling == 0)
                    {
                        Bar5 = 0;
                    }
                    else
                    {
                        Bar5 = 100 * this.ArchitectureToSurvey.Commerce / this.ArchitectureToSurvey.CommerceCeiling;
                    }
                    if (this.ArchitectureToSurvey.Technology == 0 || this.ArchitectureToSurvey.TechnologyCeiling == 0)
                    {
                        Bar6 = 0;
                    }
                    else
                    {
                        Bar6 = 100 * this.ArchitectureToSurvey.Technology / this.ArchitectureToSurvey.TechnologyCeiling;
                    }
                    if (this.ArchitectureToSurvey.Morale == 0 || this.ArchitectureToSurvey.MoraleCeiling == 0)
                    {
                        Bar7 = 0;
                    }
                    else
                    {
                        Bar7 = 100 * this.ArchitectureToSurvey.Morale / this.ArchitectureToSurvey.MoraleCeiling;
                    }
                    if (this.ArchitectureToSurvey.FacilityPositionCount - this.ArchitectureToSurvey.FacilityPositionLeft == 0 || this.ArchitectureToSurvey.FacilityPositionCount == 0)
                    {
                        Bar8 = 0;
                    }
                    else
                    {
                        Bar8 = 100 * (this.ArchitectureToSurvey.FacilityPositionCount - this.ArchitectureToSurvey.FacilityPositionLeft) / this.ArchitectureToSurvey.FacilityPositionCount;
                    }
                    ArmyBarTexture = Army6BarTexture;
                    if (Bar1 < 10)
                    {
                        ArmyBarTexture = Army1BarTexture;
                    }
                    else if (Bar1 < 20)
                    {
                        ArmyBarTexture = Army2BarTexture;
                    }
                    else if (Bar1 < 50)
                    {
                        ArmyBarTexture = Army3BarTexture;
                    }
                    else if (Bar1 < 80)
                    {
                        ArmyBarTexture = Army4BarTexture;
                    }
                    else if (Bar1 < 100)
                    {
                        ArmyBarTexture = Army5BarTexture;
                    }
                    DominationBarTexture = Domination6BarTexture;
                    if (Bar2 < 10)
                    {
                        DominationBarTexture = Domination1BarTexture;
                    }
                    else if (Bar2 < 20)
                    {
                        DominationBarTexture = Domination2BarTexture;
                    }
                    else if (Bar2 < 50)
                    {
                        DominationBarTexture = Domination3BarTexture;
                    }
                    else if (Bar2 < 80)
                    {
                        DominationBarTexture = Domination4BarTexture;
                    }
                    else if (Bar2 < 100)
                    {
                        DominationBarTexture = Domination5BarTexture;
                    }
                    EnduranceBarTexture = Endurance6BarTexture;
                    if (Bar3 < 10)
                    {
                        EnduranceBarTexture = Endurance1BarTexture;
                    }
                    else if (Bar3 < 20)
                    {
                        EnduranceBarTexture = Endurance2BarTexture;
                    }
                    else if (Bar3 < 50)
                    {
                        EnduranceBarTexture = Endurance3BarTexture;
                    }
                    else if (Bar3 < 80)
                    {
                        EnduranceBarTexture = Endurance4BarTexture;
                    }
                    else if (Bar3 < 100)
                    {
                        EnduranceBarTexture = Endurance5BarTexture;
                    }
                    AgricultureBarTexture = Agriculture6BarTexture;
                    if (Bar4 < 10)
                    {
                        AgricultureBarTexture = Agriculture1BarTexture;
                    }
                    else if (Bar4 < 20)
                    {
                        AgricultureBarTexture = Agriculture2BarTexture;
                    }
                    else if (Bar4 < 50)
                    {
                        AgricultureBarTexture = Agriculture3BarTexture;
                    }
                    else if (Bar4 < 80)
                    {
                        AgricultureBarTexture = Agriculture4BarTexture;
                    }
                    else if (Bar4 < 100)
                    {
                        AgricultureBarTexture = Agriculture5BarTexture;
                    }
                    CommerceBarTexture = Commerce6BarTexture;
                    if (Bar5 < 10)
                    {
                        CommerceBarTexture = Commerce1BarTexture;
                    }
                    else if (Bar5 < 20)
                    {
                        CommerceBarTexture = Commerce2BarTexture;
                    }
                    else if (Bar5 < 50)
                    {
                        CommerceBarTexture = Commerce3BarTexture;
                    }
                    else if (Bar5 < 80)
                    {
                        CommerceBarTexture = Commerce4BarTexture;
                    }
                    else if (Bar5 < 100)
                    {
                        CommerceBarTexture = Commerce5BarTexture;
                    }
                    TechnologyBarTexture = Technology6BarTexture;
                    if (Bar6 < 10)
                    {
                        TechnologyBarTexture = Technology1BarTexture;
                    }
                    else if (Bar6 < 20)
                    {
                        TechnologyBarTexture = Technology2BarTexture;
                    }
                    else if (Bar6 < 50)
                    {
                        TechnologyBarTexture = Technology3BarTexture;
                    }
                    else if (Bar6 < 80)
                    {
                        TechnologyBarTexture = Technology4BarTexture;
                    }
                    else if (Bar6 < 100)
                    {
                        TechnologyBarTexture = Technology5BarTexture;
                    }
                    MoraleBarTexture = Morale6BarTexture;
                    if (Bar7 < 10)
                    {
                        MoraleBarTexture = Morale1BarTexture;
                    }
                    else if (Bar7 < 20)
                    {
                        MoraleBarTexture = Morale2BarTexture;
                    }
                    else if (Bar7 < 50)
                    {
                        MoraleBarTexture = Morale3BarTexture;
                    }
                    else if (Bar7 < 80)
                    {
                        MoraleBarTexture = Morale4BarTexture;
                    }
                    else if (Bar7 < 100)
                    {
                        MoraleBarTexture = Morale5BarTexture;
                    }
                    FacilityCountBarTexture = FacilityCount6BarTexture;
                    if (Bar8 < 10)
                    {
                        FacilityCountBarTexture = FacilityCount1BarTexture;
                    }
                    else if (Bar8 < 20)
                    {
                        FacilityCountBarTexture = FacilityCount2BarTexture;
                    }
                    else if (Bar8 < 50)
                    {
                        FacilityCountBarTexture = FacilityCount3BarTexture;
                    }
                    else if (Bar8 < 80)
                    {
                        FacilityCountBarTexture = FacilityCount4BarTexture;
                    }
                    else if (Bar8 < 100)
                    {
                        FacilityCountBarTexture = FacilityCount5BarTexture;
                    }


                }
            }
        }

        private int meigongzuoderenshu(Architecture jianzhu)
        {
            int renshu = 0;
            foreach (Person person in jianzhu.Persons.GetList())
            {
                if (person.WorkKind == ArchitectureWorkKind.无)
                {
                    renshu++;
                }
            }
            return renshu;
        }

        public Point DisplayOffset
        {
            get
            {
                return this.displayOffset;
            }
            set
            {
                this.displayOffset = value;
                this.ResetTextsPosition();
            }
        }
        //以下添加

        private Rectangle AKBackgroundDisplayPosition
        {
            get
            {
                    return new Rectangle(this.AKBackground0Client.X + this.DisplayOffset.X, this.AKBackground0Client.Y + this.DisplayOffset.Y, this.AKBackground0Client.Width, this.AKBackground0Client.Height);

            }
        }
        private Rectangle ArmyBarDisplayPosition
        {
            get
            {
                if (this.ArchitectureToSurvey.ArmyQuantity == 0)
                {
                 return new Rectangle(this.ArmyBarClient.X + this.DisplayOffset.X, this.ArmyBarClient.Y + this.DisplayOffset.Y, 0, this.ArmyBarClient.Height);
               
                }
                 return new Rectangle(this.ArmyBarClient.X + this.DisplayOffset.X, this.ArmyBarClient.Y + this.DisplayOffset.Y, this.ArmyBarClient.Width * this.ArchitectureToSurvey.MilitaryCount / this.ArchitectureToSurvey.ArmyQuantity, this.ArmyBarClient.Height);
            }
        }
        private Rectangle DominationBarDisplayPosition
        {
            get
            {
                if (this.ArchitectureToSurvey.Domination == 0 && this.ArchitectureToSurvey.DominationCeiling == 0)
                {
                    return new Rectangle(this.DominationBarClient.X + this.DisplayOffset.X, this.DominationBarClient.Y + this.DisplayOffset.Y, 0, this.DominationBarClient.Height);

                }
                return new Rectangle(this.DominationBarClient.X + this.DisplayOffset.X, this.DominationBarClient.Y + this.DisplayOffset.Y, this.DominationBarClient.Width * this.ArchitectureToSurvey.Domination / this.ArchitectureToSurvey.DominationCeiling, this.DominationBarClient.Height);

            }
        }
        private Rectangle EnduranceBarDisplayPosition
        {
            get
            {
                if (this.ArchitectureToSurvey.Endurance == 0 && this.ArchitectureToSurvey.EnduranceCeiling == 0)
                {
                    return new Rectangle(this.EnduranceBarClient.X + this.DisplayOffset.X, this.EnduranceBarClient.Y + this.DisplayOffset.Y, 0, this.EnduranceBarClient.Height);

                }
                return new Rectangle(this.EnduranceBarClient.X + this.DisplayOffset.X, this.EnduranceBarClient.Y + this.DisplayOffset.Y, this.EnduranceBarClient.Width * this.ArchitectureToSurvey.Endurance / this.ArchitectureToSurvey.EnduranceCeiling, this.EnduranceBarClient.Height);

            }
        }
        private Rectangle AgricultureBarDisplayPosition
        {
            get
            {
                if (this.ArchitectureToSurvey.Agriculture == 0 && this.ArchitectureToSurvey.AgricultureCeiling == 0)
                {
                    return new Rectangle(this.AgricultureBarClient.X + this.DisplayOffset.X, this.AgricultureBarClient.Y + this.DisplayOffset.Y, 0, this.AgricultureBarClient.Height);                 

                }
                return new Rectangle(this.AgricultureBarClient.X + this.DisplayOffset.X, this.AgricultureBarClient.Y + this.DisplayOffset.Y, this.AgricultureBarClient.Width * this.ArchitectureToSurvey.Agriculture / this.ArchitectureToSurvey.AgricultureCeiling, this.AgricultureBarClient.Height);

            }
        }
        private Rectangle CommerceBarDisplayPosition
        {
            get
            {
                if (this.ArchitectureToSurvey.Commerce == 0 && this.ArchitectureToSurvey.CommerceCeiling == 0)
                {
                    return new Rectangle(this.CommerceBarClient.X + this.DisplayOffset.X, this.CommerceBarClient.Y + this.DisplayOffset.Y, 0, this.CommerceBarClient.Height);

                }
                return new Rectangle(this.CommerceBarClient.X + this.DisplayOffset.X, this.CommerceBarClient.Y + this.DisplayOffset.Y, this.CommerceBarClient.Width * this.ArchitectureToSurvey.Commerce / this.ArchitectureToSurvey.CommerceCeiling, this.CommerceBarClient.Height);

            }
        }
        private Rectangle TechnologyBarDisplayPosition
        {
            get
            {
                if (this.ArchitectureToSurvey.Technology == 0 && this.ArchitectureToSurvey.TechnologyCeiling == 0)
                {
                    return new Rectangle(this.TechnologyBarClient.X + this.DisplayOffset.X, this.TechnologyBarClient.Y + this.DisplayOffset.Y, 0, this.TechnologyBarClient.Height);

                }
                return new Rectangle(this.TechnologyBarClient.X + this.DisplayOffset.X, this.TechnologyBarClient.Y + this.DisplayOffset.Y, this.TechnologyBarClient.Width * this.ArchitectureToSurvey.Technology / this.ArchitectureToSurvey.TechnologyCeiling, this.TechnologyBarClient.Height);

            }
        }
        private Rectangle MoraleBarDisplayPosition
        {
            get
            {
                if (this.ArchitectureToSurvey.Morale == 0 || this.ArchitectureToSurvey.MoraleCeiling == 0)
                {
                    return new Rectangle(this.MoraleBarClient.X + this.DisplayOffset.X, this.MoraleBarClient.Y + this.DisplayOffset.Y, 0, this.MoraleBarClient.Height);

                }
                return new Rectangle(this.MoraleBarClient.X + this.DisplayOffset.X, this.MoraleBarClient.Y + this.DisplayOffset.Y, this.MoraleBarClient.Width * this.ArchitectureToSurvey.Morale / this.ArchitectureToSurvey.MoraleCeiling, this.MoraleBarClient.Height);

            }
        }
        private Rectangle FacilityCountBarDisplayPosition
        {
            get
            {
                if (this.ArchitectureToSurvey.FacilityPositionCount - this.ArchitectureToSurvey.FacilityPositionLeft == 0 || this.ArchitectureToSurvey.FacilityPositionCount == 0)
                {
                    return new Rectangle(this.FacilityCountBarClient.X + this.DisplayOffset.X, this.FacilityCountBarClient.Y + this.DisplayOffset.Y, 0, this.FacilityCountBarClient.Height);
                }
                return new Rectangle(this.FacilityCountBarClient.X + this.DisplayOffset.X, this.FacilityCountBarClient.Y + this.DisplayOffset.Y, this.FacilityCountBarClient.Width * (this.ArchitectureToSurvey.FacilityPositionCount - this.ArchitectureToSurvey.FacilityPositionLeft) / this.ArchitectureToSurvey.FacilityPositionCount, this.FacilityCountBarClient.Height);

            }
        }







    }



}
