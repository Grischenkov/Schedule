using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Schedule.ModelInterfaces;
using Schedule.ModelMocks;

namespace Schedule.Models.ViewModels
{
    public class UserViewModel
    {
        private readonly ITeacher teacher = new MockTeacher();
        private readonly IStudent student = new MockStudent();

        public User User { get; set; } = null;

        public Teacher Teacher { get; private set; } = null;

        public Student Student { get; private set; } = null;

        public void GetTeacher()
        {
            Teacher = teacher.GetTeachers.FirstOrDefault(_teacher => _teacher.Mail == User.Mail);
        }

        public void GetStudent()
        {
            Student = student.GetStudents.FirstOrDefault(_student => _student.Mail == User.Mail);
        }

        public static  User TryLogin(string mail, string password)
        {
            ITeacher teacher = new MockTeacher();
            IStudent student = new MockStudent();
            User user = null;
            if (teacher.GetTeachers.Any(_teacher => _teacher.Mail == mail && _teacher.Password == password))
            {
                user = new User
                {
                    Mail = mail,
                    Password = Cipher.Encrypt(password, mail),
                    IsTeacher = true
                };
            }

            if (user != null) return user;
            if (student.GetStudents.Any(_student => _student.Mail == mail && _student.Password == password))
            {
                user = new User
                {
                    Mail = mail,
                    Password = Cipher.Encrypt(password, mail),
                    IsTeacher = false
                };
            }
            if (user != null) return user;
            throw new Exception("Некорректные данные");
        }

        public static void RestorePassword(string mail)
        {
            ITeacher teacher = new MockTeacher();
            IStudent student = new MockStudent();

            foreach (var _teacher in teacher.GetTeachers)
            {
                if (_teacher.Mail != mail) continue;
                MailMessage message = new MailMessage(
                    "nikita@grishchenkov.ru",
                    mail,
                    "Восстановление пароля",
                    $"Здравствуйте, {_teacher.Surname} {_teacher.Name} {_teacher.MiddleName}. \n\nДля вашей учетной записи был получен запрос на восстановление пароля. Если это были не вы, следует сменить пароль в личном кабинете. \n\n Данные для входа: \n Почта: {_teacher.Mail} \n Пароль: {_teacher.Password}");
                SmtpClient client = new SmtpClient
                {
                    Host = "smtp.yandex.ru",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("nikita@grishchenkov.ru", "1970071026Tn")
                };
                client.Send(message);
                return;
            }

            foreach (var _student in student.GetStudents)
            {
                if (_student.Mail != mail) continue;
                MailMessage message = new MailMessage(
                    "nikita@grishchenkov.ru",
                    mail,
                    "Восстановление пароля",
                    $"Здравствуйте, {_student.Surname} {_student.Name} {_student.MiddleName}. \n\nДля вашей учетной записи был получен запрос на восстановление пароля. Если это были не вы, следует сменить пароль в личном кабинете. \n\n Данные для входа: \n Почта: {_student.Mail} \n Пароль: {_student.Password}");
                SmtpClient client = new SmtpClient
                {
                    Host = "smtp.yandex.ru",
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential("nikita@grishchenkov.ru", "1970071026Tn")
                };
                client.Send(message);
                return;
            }
            throw new Exception();
        }

    }
}
