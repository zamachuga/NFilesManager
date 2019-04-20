﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NFilesManager.Code.Interfaces;

namespace NFilesManager.Code.Controllers
{
    /// <summary>
    /// Основной контроллер.
    /// </summary>
    public class GeneralController
    {
        #region Конструкторы/инициализаторы.
        /// <summary>
        /// Создать контроллер.
        /// </summary>
        public GeneralController()
        {
            Form = new FGeneral();
        }
        #endregion

        #region Свойства.
        /// <summary>
        /// Форма.
        /// </summary>
        public Form Form { get; }
        #endregion

        #region События.
        #endregion

        #region Методы.
        #endregion
    }
}
