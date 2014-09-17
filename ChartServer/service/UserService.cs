using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChartServer.model;

namespace ChartServer.service
{
    public interface UserService
    {
        Boolean isValid(String id);

        Boolean save(User user);

        Boolean update(User user);

        Boolean changePass(User user);

        Boolean delete(User user);

        User findById(String id);

        List<User> findAll();
    }
}
