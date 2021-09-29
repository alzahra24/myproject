using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Students_Challenge.Data
{
    public class StudentService
    {
        #region Property
        private readonly DataContext _appDBContext;
        #endregion

        #region Constructor
        public StudentService(DataContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Students
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _appDBContext.student.ToListAsync();
        }
        #endregion

        #region Get List of Classes
        public async Task<List<classes>> GetAllClassesAsync()
        {
            return await _appDBContext.classes.ToListAsync();
        }
        #endregion

        #region Get List of Countries
        public async Task<List<countries>> GetAllCountriesAsync()
        {
            return await _appDBContext.countries.ToListAsync();
        }
        #endregion

        #region Insert Student
        public async Task<bool> InsertStudentAsync(Student student)
        {
            await _appDBContext.student.AddAsync(student);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Insert Class
        public async Task<bool> InsertClassAsync(classes classes)
        {
            await _appDBContext.classes.AddAsync(classes);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Insert Country
        public async Task<bool> InsertCountryAsync(countries countries)
        {
            await _appDBContext.countries.AddAsync(countries);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Student by Id
        public async Task<Student> GetStudentAsync(int id)
        {
            Student student = await _appDBContext.student.FirstOrDefaultAsync(c => c.id.Equals(id));
            return student;
        }
        #endregion

        #region Get Class by Id
        public async Task<classes> GetClassAsync(int id)
        {
            classes classes = await _appDBContext.classes.FirstOrDefaultAsync(c => c.id.Equals(id));
            return classes;
        }
        #endregion

        #region Get Country by Id
        public async Task<countries> GetCountryAsync(int id)
        {
            countries countries = await _appDBContext.countries.FirstOrDefaultAsync(c => c.id.Equals(id));
            return countries;
        }
        #endregion



        #region Update Student
        public async Task<bool> UpdateStudentAsync(Student student)
        {
             _appDBContext.student.Update(student);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Update Class
        public async Task<bool> UpdateClassAsync(classes classes)
        {
            _appDBContext.classes.Update(classes);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Update Country
        public async Task<bool> UpdateCountryAsync(countries countries)
        {
            _appDBContext.countries.Update(countries);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete Student
        public async Task<bool> DeleteStudentAsync(Student student)
        {
            _appDBContext.Remove(student);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete Class
        public async Task<bool> DeleteClassAsync(classes classes)
        {
            _appDBContext.Remove(classes);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Delete Country
        public async Task<bool> DeleteCountryAsync(countries countries)
        {
            _appDBContext.Remove(countries);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}